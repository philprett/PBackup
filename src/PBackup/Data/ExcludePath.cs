using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBackup.Data
{
    public class ExcludePath
    {
        [Key]
        public long Id { get; set; }
        public string Path { get; set; }

        public ExcludePath() 
        {
            Id.SetRandom();
            Path = string.Empty;
        }
    }
}
