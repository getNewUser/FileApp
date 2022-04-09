using System;
using System.Collections.Generic;
using System.IO;

namespace FileScannerApp
{
    public class FileService
    {
        private readonly ApplicationDbContext _context = new();

        public void SaveFilesWithFolders(List<string> files)
        {
            foreach (var file in files)
            {
                var folder = _context.GetOrCreateFolder(file);
                var newFile = new File { Id = Guid.NewGuid(), Name = Path.GetFileName(file), Folder = folder };
                _context.Files.Add(newFile);
                _context.SaveChanges();
            }
        }
    }
}
