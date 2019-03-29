using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBackup.Data
{
    internal class BackupBrowserGridItem
    {
        public string Name { get; set; }
        public string LastModified { get; set; }
        public string Size { get; set; }
        public string Versions { get; set; }
        public BackupFile BackupFile { get; set; }

    }
}
