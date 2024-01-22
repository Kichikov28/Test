using System;
using System.Collections.Generic;
using System.IO;
public class Program
{
    static void Main(string[] args)
    {
        string path = Console.ReadLine();
        string[] getFiles = Directory.GetFiles(path);
        Dictionary<string, int> files = new Dictionary<string, int>();
        foreach (string file in getFiles)
        {
            int dotIndex = file.LastIndexOf('.');
            string extension = file.Substring(dotIndex);
            if (files.ContainsKey(extension))
            {
                files[extension]++;
            }
            else
            {
                files.Add(extension, 1);
            }
        }
        foreach (var kvp in files)
        {
            Console.WriteLine($"{kvp.Key} - {kvp.Value} files.");
        }

    }
}

