using PBackup.LongFilenames;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBackup.Data
{
    public class BackupDbContext : DbContext
    {
        private static BackupDbContext singleton;

        private static string destination = null;
        public static string Destination
        {
            get
            {
                if (destination == null)
                {
                    Configuration conf = MainDbContext.DB.Configurations.FirstOrDefault(c => c.Name == "destination");
                    if (conf == null)
                    {
                        throw new MissingFieldException("There is no 'destination' value in the configuration.");
                    }
                    destination = conf.Value;
                }
                return destination;
            }
            set
            {
                destination = value;
                Configuration conf = MainDbContext.DB.Configurations.FirstOrDefault(c => c.Name == "destination");
                if (conf == null)
                {
                    conf = new Configuration { Name = "destination", Value = value };
                }
                MainDbContext.DB.Configurations.Add(conf);
                MainDbContext.DB.SaveChanges();
            }
        }


        private static System.Data.SQLite.SQLiteConnection Connection
        {
            get
            {
                if (!LongDirectory.Exists(Destination)) LongDirectory.CreateDirectory(Destination);

                string filename = System.IO.Path.Combine(Destination, "pbackup.db");
                return new System.Data.SQLite.SQLiteConnection(string.Format("Data Source={0}", filename));
            }
        }

        private BackupDbContext() : base(Connection, true)
        {
            Database.SetInitializer<BackupDbContext>(new CreateDatabaseIfNotExists<BackupDbContext>());
        }
        public static BackupDbContext DB
        {
            get
            {
                if (singleton == null)
                {
                    singleton = new BackupDbContext();
                    singleton.InitializeTables();
                }
                return singleton;
            }
        }

        public static void Reset()
        {
            singleton = null;
            var dummy = DB;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public void InitializeTables()
        {
            Database.ExecuteSqlCommand(
                "CREATE TABLE IF NOT EXISTS BackupFile " +
                "(" +
                "Id INTEGER NOT NULL PRIMARY KEY, " +
                "Path TEXT NOT NULL, " +
                "LastModified DATETIME NOT NULL," +
                "Size INTEGER NOT NULL," +
                "BackupTimestamp DATETIME NOT NULL, " +
                "BackupLocation TEXT NOT NULL, " +
                "Parent TEXT NOT NULL, " +
                "Name TEXT NOT NULL " +
                ")");
        }

        public DbSet<BackupFile> BackupFiles { get; set; }
    }
}
