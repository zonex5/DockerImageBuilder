using System;
using System.Drawing;
using System.Threading.Tasks;

namespace DockerImageBuilder
{
    public abstract class BuildService
    {
        private const string GRADLE_BUILD = @"/c gradlew clean build -x testClasses";
        private const string MAVEN_BUILD = @"/c mvn clean install -Dmaven.test.skip=true";
        private const string DOCKER_BUILD = @"/c docker build -t {0}:{1} .";
        private const string LOAD_IMAGE = @"/c minikube image load {0}:{1}";

        public static event Action<string, Color> OnLogRequest = delegate { };

        public static async Task BuildProject(string path)
        {
            switch (Service.ProjectVcs(path))
            {
                case VcType.Gradle:
                    await Service.RunProcessAsync(GRADLE_BUILD, path);
                    break;
                case VcType.Maven:
                    await Service.RunProcessAsync(MAVEN_BUILD, path);
                    break;
                case VcType.None:
                default:
                    OnLogRequest("No VCS project found.", Color.Chocolate);
                    break;
            }
        }

        public static async Task BuildDockerImage(string projectPath, string imageName, string imageTag)
        {
            if (!Service.IsDocker(projectPath))
            {
                OnLogRequest("No Dockerfile found.", Color.Chocolate);
                return;
            }

            await Service.RunProcessAsync(string.Format(DOCKER_BUILD, imageName, imageTag), projectPath);
        }

        public static async Task LoadImageToMinikube(string projectPath, string imageName, string imageTag)
        {
            await Service.RunProcessAsync(string.Format(imageName, imageTag), projectPath);
        }
    }
}