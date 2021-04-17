using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Login
{
    class Program
    {
        static void Main(String []
        args)
            {
            Console.WriteLine("Create New User");

            String username, password = string.Empty;

            Console.Write("Enter a username");
            username = Console.ReadLine();
            Console.Write("Enter a password");
            password = Console.ReadLine();

            using (StreamWriter sw = new StreamWriter(File.Create("C:\\1.txt")))
            {
                sw.Write(username);
                sw.Write(password);
                sw.Close ();

                Console.WriteLine("Done");

            Console.Read();
            }
        }
    }
}