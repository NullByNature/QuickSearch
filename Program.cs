using System;
using System.IO;
using System.Threading.Tasks;
using QuickSearch;

namespace QuickSearch
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Instance of program 
            Program program = new Program();
            // Actual program
            Console.WriteLine("QuickSearch v1.0.0 by NullByNature");
            Console.WriteLine("You can select from the following directories to search from, more will be added later on");
            Console.WriteLine("1. Desktop Directory\n" +
                "2. Documents Directory\n" +
                "3. Downloads Directory\n");
            Console.Write("Input: ");
            // User input
            string user_answer = Console.ReadLine();
            // Make sure user input is not empty
            while(string.IsNullOrEmpty(user_answer))
            {
                Console.WriteLine("Your answer can not be empty");
                user_answer = Console.ReadLine();
            }
            // dir search 
            await program.DirectorySearch(user_answer);
        }

        #region File methods


        async Task DirectorySearch(string directory)
        {
            DirSearch dir = new DirSearch();
            switch (directory)
            {
                case "1":
                    string Desktop_Path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                    Console.WriteLine("Enter the keyword you are looking for");
                    Console.Write("Keyword: ");
                    string downloads_keyword = Console.ReadLine();
                    // make sure keyword is not empty 
                    while (string.IsNullOrEmpty(downloads_keyword))
                    {
                        Console.WriteLine("Your keyword search can not be left blank");
                        Console.Write("Keyword: ");
                        downloads_keyword = Console.ReadLine();
                    }
                    await dir.Keyword(downloads_keyword, Desktop_Path);
                    break;
                case "2":
                    string Documents_Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    Console.WriteLine("Enter the keyword you are looking for");
                    Console.Write("Keyword: ");
                    string Documents_keyword = Console.ReadLine();
                    // make sure keyword is not empty 
                    while (string.IsNullOrEmpty(Documents_keyword))
                    {
                        Console.WriteLine("Your keyword search can not be left blank");
                        Console.Write("Keyword: ");
                        Documents_keyword = Console.ReadLine();
                    }
                    await dir.Keyword(Documents_keyword, Documents_Path);
                    break;
                case "3":
                    string Downloads_Path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
                    Console.WriteLine("Enter the keyword you are looking for");
                    Console.Write("Keyword: ");
                    string Downloads_keyword = Console.ReadLine();
                    // make sure keyword is not empty 
                    while (string.IsNullOrEmpty(Downloads_keyword))
                    {
                        Console.WriteLine("Your keyword search can not be left blank");
                        Console.Write("Keyword: ");
                        Downloads_keyword = Console.ReadLine();
                    }
                    await dir.Keyword(Downloads_keyword, Downloads_Path);
                    break;
            }
        }
        #endregion
    }
}