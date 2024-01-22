using System;
using System.Collections.Generic;
using System.IO;

namespace P15_FileManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> info = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("-");
                string extension = input[0].Trim();
                string folderName = input[1].Trim();
                info[extension] = folderName;
            }

            if (Directory.Exists(path))
            {
                foreach (string filePath in Directory.GetFiles(path))
                {
                    string extension = Path.GetExtension(filePath).Trim('.').ToLower();

                    if (info.ContainsKey(extension))
                    {
                        string destinationFolder = Path.Combine(path, info[extension]);

                        if (!Directory.Exists(destinationFolder))
                        {
                            Directory.CreateDirectory(destinationFolder);
                        }
                        string destinationPath = Path.Combine(destinationFolder, Path.GetFileName(filePath));

                        File.Copy(filePath, destinationPath, true);
                    }
                }
                foreach (var item in info)
                {
                    string destinationFolder = Path.Combine(path, item.Value);
                    int copiedFilesCount = Directory.GetFiles(destinationFolder).Length;

                    Console.WriteLine($"{destinationFolder}");
                    Console.WriteLine($"Copied Files: {copiedFilesCount}\n");
                }
            }
            else
            {
                Console.WriteLine("Invalid path!");
            }
        }
    }
}
