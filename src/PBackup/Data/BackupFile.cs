﻿using PBackup.LongFilenames;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBackup.Data
{
    public class BackupFile
    {
        [Key]
        public long Id { get; set; }
        public string Path { get; set; }
        public DateTime LastModified { get; set; }
        public long Size { get; set; }
        public DateTime BackupTimestamp { get; set; }
        public string BackupLocation { get; set; }

        public BackupFile() : base()
        {
            Id.SetRandom();
            Path = string.Empty;
            LastModified = DateTime.MinValue;
            Size = 0;
            BackupTimestamp = DateTime.MinValue;
            BackupLocation = string.Empty;
        }

    }
}
