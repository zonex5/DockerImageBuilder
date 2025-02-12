namespace DockerImageBuilder.Services
{
    public abstract class Registry
    {
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