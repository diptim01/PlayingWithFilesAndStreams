// See https://aka.ms/new-console-template for more information

using System;
using System.IO;
using FilesProcessing;

if (args.Length > 0)
{
    var command = args[0];

    if (command == "--file")
    {
        var filePath = args[1];
        if (!Path.IsPathFullyQualified(filePath))
        {
            Console.WriteLine($"ERROR! file path - {filePath} is not fully qualified");
            return;
        }
        Console.WriteLine($"Processing single file name - {filePath}");
        ProcessSingleFile(filePath);
    }else if (command == "--dir")
    {
        var directoryPath = args[1];
        var fileType = args[2];
        Console.WriteLine($"Directory {directoryPath} selected for {fileType} type");
        ProcessDirectory(directoryPath,fileType);
    }
    else
    {
        Console.WriteLine("Invalid command Line options");
    }
}
else
{
    Console.WriteLine("No Args -");
}

Console.WriteLine("Press Enter to Quit");
Console.ReadLine();

void ProcessSingleFile(string filePath)
{
    var fileProcessor = new FileProcessor(filePath);
    fileProcessor.Process();
}

void ProcessDirectory(string directoryPath, string fileType)
{
}