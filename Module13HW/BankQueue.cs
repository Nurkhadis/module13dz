using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module13HW
{
    class BankQueue
    {
        private Queue<Client> queue = new Queue<Client>();

        public void Enqueue(Client client)
        {
            queue.Enqueue(client);
            Console.WriteLine($"{client.Id} get up in the queue for {client.ServiceType}. Current queue length: {queue.Count}");
        }

        public void Dequeue()
        {
            if (queue.Count > 0)
            {
                Client servedClient = queue.Dequeue();
                Console.WriteLine($"Customer served {servedClient.Id} ({servedClient.ServiceType}). Current queue length: {queue.Count}");
            }
            else
            {
                Console.WriteLine("The queue is empty. There are no customers to service.");
            }
        }
        public void DisplayQueue()
        {
            Console.WriteLine("Current queue:");
            foreach (var client in queue)
            {
                Console.WriteLine($"- {client.Id} ({client.ServiceType})");
            }
        }
    }
}
