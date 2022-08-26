using System;
using System.IO;

namespace FilesProcessing
{
    public class FileProcessor
    {
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
        }
    }
}