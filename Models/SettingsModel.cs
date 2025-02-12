namespace DockerImageBuilder.Models
{
    public class SettingsModel
    {
        public bool BuildProject { get; set; }
        public bool BuildImage { get; set; }
        public bool LoadImage { get; set; }
        public bool DeleteImage { get; set; }
    }
}