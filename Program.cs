using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the directory path to search: ");
        string target_dir = Console.ReadLine();
        Console.Write("Enter the name of the subdirectory to search: ");
        string folder_name = Console.ReadLine();

        if (!Directory.Exists(target_dir))
        {
            Console.WriteLine($"Catalog {target_dir} not found.");
            Console.ReadLine();
            return;
        }

        bool found = false;

        foreach (string subdir in Directory.GetDirectories(target_dir))
        {
            if (Path.GetFileName(subdir).Equals(folder_name, StringComparison.OrdinalIgnoreCase))
            {
                found = true;
                Console.WriteLine($"Subcatalog {folder_name} found in catalog {Path.GetDirectoryName(subdir)}.");
            }
        }

        if (!found)
        {
            Console.WriteLine($"Subcatalog {folder_name} not found in catalog {target_dir}.");
        }

        Console.ReadLine();
    }
}