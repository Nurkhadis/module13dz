using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module13HW
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankQueue bankQueue = new BankQueue();

            while (true)
            {
                Console.WriteLine("\nSelect an action:");
                Console.WriteLine("1. Add client to queue");
                Console.WriteLine("2. Serve the next customer");
                Console.WriteLine("3. Show the current queue");
                Console.WriteLine("0. Exit the program");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter client's id: ");
                        string clientId = Console.ReadLine();
                        Console.Write("Choose the type of service (loan, deposit, consultation, etc.): ");
                        string serviceType = Console.ReadLine();
                        bankQueue.Enqueue(new Client(clientId, serviceType));
                        break;
                    case "2":
                        bankQueue.Dequeue();
                        break;
                    case "3":
                        bankQueue.DisplayQueue();
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Incorrect input. Please select an action from the list.");
                        break;
                }
            }
        }
    }
}
