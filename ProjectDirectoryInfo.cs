using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DockerImageBuilder
{
    public class ProjectDirectoryInfo
    {
        public string Caption { get; set; }
        public string Path { get; set; }
        public Statuses Status { get; set; }
        public bool Checked { get; set; }
    }
}
