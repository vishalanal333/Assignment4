using System;
using System.IO;
using System.Text;

namespace Assignment4
{
    class Program
    {
        static void choice(string path)
        {
            Console.WriteLine("Please choose");
            Console.WriteLine("1. Write text to file");
            Console.WriteLine("2. Show text from file");
            Console.WriteLine("3. Exit");
            string input = Console.ReadLine();
            if (input == "1")
            {
                writeFile(path);
            }
            else if (input == "2")
            {
                readFile(path);
            }
            else if (input == "3")
            {
                Console.WriteLine("Bye");
            }
            else
            {
                Console.WriteLine("invalid input");
                choice(path);
            }
        }
        static void writeFile(string path)
        {
            using (FileStream file = new FileStream(path, FileMode.Append, FileAccess.Write))
            {

                using (StreamWriter a = new StreamWriter(file, Encoding.UTF8))
                {
                    String data = Console.ReadLine();
                    a.WriteLine(data);
                }
            }
            choice(path);

        }
        static void readFile(string path)
        {
            using (FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader b = new StreamReader(file))
                {
                    String readLine = "";
                    while ((readLine = b.ReadLine()) != null)
                    {
                        Console.WriteLine(readLine);
                    }
                }
            }
            choice(path);
        }
        static void Main(string[] args)
        {
            string path = @"myFile.txt";
            choice(path);
        }
    }
}
