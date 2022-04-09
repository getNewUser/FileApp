using System.IO;
using System.Linq;

namespace FileScannerApp
{
    internal class Program
    {
        private static readonly FileService _fileService = new();
        static void Main(string[] args)
        {
            var path = @"C:\Steep";
            var files = Directory.EnumerateFiles(path, "*", SearchOption.AllDirectories).ToList();

            _fileService.SaveFilesWithFolders(files);
        }
    }
}
