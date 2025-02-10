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

        public bool? IsDocker { get; set; } = true;

        public bool? IsBuild  { get; set; } = true;

        /*[JsonIgnore]
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
        public Image DockerIcon => Docker ? Properties.Resources.docker16 : Properties.Resources.empty;*/
    }
}