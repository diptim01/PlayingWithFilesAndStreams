using System;
using System.IO;

namespace FilesProcessing
{
    public class FileProcessor
    {
        private const string BackupDirectory = "Backup";
        private readonly string _filePath;

        public FileProcessor(string filePath)
        {
            _filePath = filePath;
        }

        public void Process()
        {
            Console.WriteLine($"Begin process for {_filePath}");
            if (!File.Exists(_filePath))
            {
                Console.WriteLine($"ERROR! file path - {_filePath} does not exist!");
            }

            var rootDirectory = new DirectoryInfo(_filePath).Parent?.Parent?.FullName;
            Console.WriteLine($"We found the root directory to the file path - {rootDirectory}");

            var backupDirectoryPath = Path.Combine(rootDirectory, BackupDirectory);

            if (!Directory.Exists(backupDirectoryPath))
            {
                Console.WriteLine($"Creating backup directory path - {backupDirectoryPath}");
                Directory.CreateDirectory(backupDirectoryPath);
            }
            
        }
    }
}