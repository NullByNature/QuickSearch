using System;
using System.IO;
using System.Runtime.CompilerServices;


namespace QuickSearch
{
    class DirSearch
    {
        public async Task Keyword(string keyword, string DirPath)
        {
            // List for saving all files that contain the keyword 
            List<string> keyword_file = new List<string>();
            string path = DirPath;
            // Get all files in the folder
            string[] files = Directory.GetFiles(path);
            // Loop through and read every file
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            // Try - Catch to prevent crashing 
            try
            {
                foreach (string file in files)
                {
                    // read all text in each file 
                    string readText = await File.ReadAllTextAsync(file);
                    if (readText.Contains(keyword))
                    {
                        string name = Path.GetFileName(file);
                        keyword_file.Add(name);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            // Check if keyword list has any files in it 
            if (keyword_file.Count == 0)
            {
                Console.WriteLine("No files found with that keyword");
            }
            else
            {
                // Loop through every file name in keyword files
                foreach (string file in keyword_file)
                {
                    Console.WriteLine($"Keyword found in file: {file}");
                }
            } 
        }
    }
}
