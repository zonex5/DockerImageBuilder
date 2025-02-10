using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DockerImageBuilder
{
    public abstract class Service
    {
        public static event Action<string, Color> OnLogRequest = delegate { };

        public static VcType ProjectVcs(string path)
        {
            if (File.Exists(Path.Combine(path, "build.gradle")) || File.Exists(Path.Combine(path, "build.gradle.kts")))
                return VcType.Gradle;
            if (File.Exists(Path.Combine(path, "pom.xml")))
                return VcType.Maven;
            return VcType.None;
        }

        private static bool IsDocker(string path)
        {
            return File.Exists(Path.Combine(path, "Dockerfile"));
        }

        public static Task RunProcessAsync(string command, string path)
        {
            return Task.Run(() =>
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = command,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    StandardOutputEncoding = Encoding.UTF8,
                    StandardErrorEncoding = Encoding.UTF8,
                    WorkingDirectory = path
                };

                using (var process = new Process())
                {
                    process.StartInfo = psi;
                    process.OutputDataReceived += (sender, e) => OnLogRequest(e.Data, Color.Black);
                    process.ErrorDataReceived += (sender, e) => OnLogRequest(e.Data, Color.OrangeRed);

                    process.Start();
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();
                    process.WaitForExit();
                }
            });
        }

        public static List<ProjectDirectoryInfo> ImportDirectory(string path)
        {
            return Directory.GetDirectories(path)
                .Select(CreateProjectDirectory)
                .Where(proj => proj != null)
                .ToList();
        }

        public static ProjectDirectoryInfo CreateProjectDirectory(string path)
        {
            var dirName = Path.GetFileName(path);
            var vcs = ProjectVcs(path);
            var isDocker = IsDocker(path);
            return vcs != VcType.None || isDocker
                ? new ProjectDirectoryInfo
                {
                    Caption = dirName,
                    Path = path,
                    Vcs = vcs,
                    IsBuild = vcs != VcType.None ? true : (bool?)null,
                    IsDocker = IsDocker(path) ? true : (bool?)null,
                    ImageTag = "0.0.1",
                    ImageName = FormatDockerImageName(dirName)
                }
                : null;
        }

        public static string GetCurrentContext()
        {
            return RunProcessForResult("kubectl", "config current-context").Trim();
        }

        public static string SetCurrentContext(string context)
        {
            return RunProcessForResult("kubectl", $"config use-context {context}");
        }

        public static List<string> GetAllContexts()
        {
            var output = RunProcessForResult("kubectl", "config get-contexts -o name");
            var contexts = new List<string>();
            foreach (var line in output.Split(new[] { Environment.NewLine, "\n" }, StringSplitOptions.RemoveEmptyEntries))
            {
                contexts.Add(line.Trim());
            }

            return contexts;
        }

        public static string FormatDockerImageName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return string.Empty;
            }

            string FormatPart(string part) => Regex.Replace(Regex.Replace(part, @"[\s._]+", "-"), @"[^a-z0-9-]", "").Trim('-');

            string[] parts = name.ToLowerInvariant().Split(new[] { '/' }, 2);
            string repository = FormatPart(parts[0]);
            string imageName = parts.Length > 1 ? FormatPart(parts[1]) : string.Empty;
            return string.IsNullOrEmpty(imageName) ? repository : $"{repository}/{imageName}";
        }


        private static Process CreateProcess(string cmd, string args)
        {
            return new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = cmd,
                    Arguments = args,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
        }

        private static string RunProcessForResult(string cmd, string args)
        {
            var process = CreateProcess(cmd, args);
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            return output;
        }

        public static void PutValueToRegistry(string key, string value)
        {
            const string keyName = @"SOFTWARE\DockerImageBuilder";
            using (var subKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(keyName))
            {
                subKey?.SetValue(key, value);
            }
        }

        public static string GetValueFromRegistry(string key)
        {
            const string keyName = @"SOFTWARE\DockerImageBuilder";
            using (var subKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(keyName))
            {
                return subKey?.GetValue(key)?.ToString();
            }
        }
    }
}