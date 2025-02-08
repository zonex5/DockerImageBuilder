using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DockerImageBuilder
{
    public class ProjectDirectoryInfo
    {
        public string Caption { get; set; }
        public string Path { get; set; }
        public string ImageName { get; set; }
        public string ImageTag { get; set; }
        public VcType Vcs { get; set; }
        public Statuses Status { get; set; }
        public bool Checked { get; set; } = true;

        [JsonIgnore]
        public Image VcIcon
        {
            get
            {
                switch (Vcs)
                {
                    case VcType.Gradle:
                        return Properties.Resources.gradle;
                    case VcType.Maven:
                        return Properties.Resources.maven;
                    default:
                        return null;
                }
            }
        }
    }
}
