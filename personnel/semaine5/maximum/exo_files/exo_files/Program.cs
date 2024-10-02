// For Directory.GetFiles and Directory.GetDirectories
// For File.Exists, Directory.Exists
using System;
using System.IO;
using System.Collections;

public class RecursiveFileProcessor
{
    public static void Main(string[] args)
    {
        var paths = new List<string>() { "C:\\Users\\po01imj\\Documents\\GitHub", "C:\\temp" };
        int totalFiles = 0;
        int totalDic = 0;
        foreach (string path in paths)
        {
            if (Directory.Exists(path))
            {
                // This path is a file
                var count = ProcessDirectory(path);
                totalFiles = count.Item1;
                totalDic = count.Item2;
            }
            Console.WriteLine($"{path} contient {totalFiles} fichiers et {totalDic} dossiers");

        }

    }

    // Process all files in the directory passed in, recurse on any directories
    // that are found, and process the files they contain.
    public static Tuple<int, int> ProcessDirectory(string targetDirectory)
    {
        
        int files = 0;
        int folders = 0;

        //Process the list of files found in the directory.
        string[] fileEntries = Directory.GetFiles(targetDirectory);
        foreach (string fileName in fileEntries) { 
            files++;
        }

        //Recurse into subdirectories of this directory.
        string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
        foreach (string subdirectory in subdirectoryEntries)
        {
            folders++;

            (int fileNum, int folderNum) = ProcessDirectory(subdirectory);
            files += fileNum;
            folders += folders;
        }

        return Tuple.Create(files, folders);
    }
}