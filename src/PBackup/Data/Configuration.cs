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

		public static Configuration Set (string name, string value = "")
		{
			Configuration conf = MainDbContext.DB.Configurations.FirstOrDefault(c => c.Name == name);
			if (conf== null)
			{
				conf = new Configuration { Name = name, Value = value };
			}
			else
			{
				conf.Value = value;
			}
			MainDbContext.DB.Configurations.Add(conf);
			MainDbContext.DB.SaveChanges();

			return conf;
		}
	}
}
