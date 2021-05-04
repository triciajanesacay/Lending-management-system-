using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LoginSystem
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Personal Loans");

            List<string> Loans = new List<string>(5);
            Loans.Add("Two thousand Pesos");
            Loans.Add("Five hundred Pesos");
            Loans.Add("One thousand Pesos");
            Loans.Add("One thousand Pesos");
            Loans.Add("Four thousandPesos");
            Loans.Add("Three thousand Pesos");
            Loans.Add("Ten thousand Pesos");
            Console.WriteLine("Original List Loans");
            Console.WriteLine("===============");

            foreach (string a in Loans)
                NewMethod(a);

            Loans.Sort();
            Console.WriteLine();
            Console.WriteLine("Sorted List of Loans");
            Console.WriteLine("===============");

            foreach (string a in Loans)
                Console.WriteLine(a);




            Console.WriteLine("Lending Mangement System Log In ");

            String username, password, username1, password1 = string.Empty;

            Console.Write("Enter a username: ");
            username = Console.ReadLine();
            Console.Write("Enter a password: ");
            password = Console.ReadLine();

            using (StreamReader sr = new StreamReader(File.Open("C:\\1.txt", FileMode.Open)))
            {
                username1 = sr.ReadLine();
                password1 = sr.ReadLine();
                sr.Close();
            }
            if
                (username == username1 && password == password1) ;
            {
                Console.WriteLine("Login Succeful");



            else
                {
                    Console.WriteLine("Login Failed");


                    Console.Read();


                }
            }
        }

        private static void NewMethod(string a)
        {
            Console.WriteLine(a);
        }

    }

