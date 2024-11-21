using System;
using System.Security.Cryptography.X509Certificates;

namespace FinTrackr
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "FinTrackr - Track your finances with ease!";
            Console.WriteLine("Hello, World!");
        }

        private static void Help(string subHelp = null)
        {
            Console.WriteLine("Usage: FinTrackr [command] [options]");
            Console.WriteLine("Commands:");

            switch (subHelp)
            {
                case "income":
                    Console.WriteLine("income add - Add an income");
                    break;
                case "expense":
                    Console.WriteLine("expense add - Add an expense");
                    break;
                default:
                    Console.WriteLine("hmm, thats weird. I don't know that command.");
                    Console.WriteLine("Try 'FinTrackr help [command]'");
                    Console.WriteLine("Commands:"); 
                    Console.WriteLine("income - Manage your income");
                    Console.WriteLine("expense - Manage your expenses");
                    break;
            }
        }
    }
}