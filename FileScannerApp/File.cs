using System;

namespace FileScannerApp
{
    public class File
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Folder Folder { get; set; }
    }
}
