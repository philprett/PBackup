using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBackup.Data
{
    public class MainDbContext : DbContext
    {
        private static MainDbContext singleton;

        private static System.Data.SQLite.SQLiteConnection Connection
        {
            get
            {
                string exeFilename = System.Reflection.Assembly.GetExecutingAssembly().Location;

                string filename = string.Empty;

                string[] args = Environment.GetCommandLineArgs();
                foreach (string arg in args)
                {
                    if (arg.StartsWith("/"))
                    {

                    }
                    else if (string.IsNullOrWhiteSpace(filename))
                    {
                        if (!arg.Equals(exeFilename, StringComparison.CurrentCultureIgnoreCase))
                        {
                            filename = arg;
                        }
                    }
                }

                if (string.IsNullOrWhiteSpace(filename))
                {
                    filename =
                        System.IO.Path.Combine(
                            System.IO.Path.GetDirectoryName(exeFilename),
                            "pbackup.db");
                }

                return
                    new System.Data.SQLite.SQLiteConnection(
                        string.Format(
                            "Data Source={0}",
                            filename));
            }
        }

        private MainDbContext() : base(Connection, true)
        {
            Database.SetInitializer<MainDbContext>(new CreateDatabaseIfNotExists<MainDbContext>());
        }

        public static MainDbContext DB
        {
            get
            {
                if (singleton == null)
                {
                    singleton = new MainDbContext();
                    singleton.InitializeTables();
                }
                return singleton;
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public void InitializeTables()
        {
            Database.ExecuteSqlCommand(
                "CREATE TABLE IF NOT EXISTS IncludePath " +
                "(" +
                "Id INTEGER NOT NULL PRIMARY KEY, " +
                "Path TEXT NOT NULL" +
                ")");

            Database.ExecuteSqlCommand(
                "CREATE TABLE IF NOT EXISTS ExcludePath " +
                "(" +
                "Id INTEGER NOT NULL PRIMARY KEY, " +
                "Path TEXT NOT NULL" +
                ")");

            Database.ExecuteSqlCommand(
                "CREATE TABLE IF NOT EXISTS Configuration " +
                "(" +
                "Id INTEGER NOT NULL PRIMARY KEY, " +
                "Name TEXT NOT NULL, " +
                "Value TEXT NOT NULL" +
                ")");

        }

        public DbSet<Configuration> Configurations { get; set; }
        public DbSet<IncludePath> IncludePaths { get; set; }
        public DbSet<ExcludePath> ExcludePaths { get; set; }

    }
}
