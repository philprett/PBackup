using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBackup.Data
{
    public class Configuration
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public Configuration() : base()
        {
            Id.SetRandom();
            Name = string.Empty;
            Value = string.Empty;
        }
    }
}
