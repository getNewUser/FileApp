using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileScannerApp
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<File> Files { get; set; }
        public DbSet<Folder> Folders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer($"Server=localhost;Database=FileDb;Trusted_Connection=True;");

        public Folder GetOrCreateFolder(string path)
        {
            var directoryName = Path.GetDirectoryName(path);
            var folder = Folders.SingleOrDefault(x => x.Name == directoryName);
            if (folder == null)
            {
                folder = new Folder { Id = Guid.NewGuid(), Name = directoryName, Files = new List<File>() };
                Folders.Add(folder);
                SaveChanges();
            }

            return folder;
        }
    }
}
