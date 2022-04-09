using System;
using System.Collections.Generic;

namespace FileScannerApp
{
    public class Folder
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<File> Files { get; set; }
    }
}
