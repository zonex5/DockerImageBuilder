using System.Drawing;
using Newtonsoft.Json;

namespace DockerImageBuilder
{
    public class ProjectDirectoryInfo
    {
        public bool Checked { get; set; } = true;
        public string Caption { get; set; }
        public string Path { get; set; }
        public string ImageName { get; set; }
        public string ImageTag { get; set; }
        public VcType Vcs { get; set; }
        public Statuses Status { get; set; }

        public bool IsDocker { get; set; }
        
        [JsonIgnore]
        public Image VcsIcon
        {
            get
            {
                switch (Vcs)
                {
                    case VcType.Gradle:
                        return Properties.Resources.gradle16;
                    case VcType.Maven:
                        return Properties.Resources.maven16;
                    default:
                        return Properties.Resources.empty;
                }
            }
        }

        [JsonIgnore]
        public Image DockerIcon => IsDocker ? Properties.Resources.docker16 : Properties.Resources.empty;
    }
}