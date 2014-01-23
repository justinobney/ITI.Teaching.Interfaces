using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ITI.Teaching.Interface.Domain;

namespace ITI.Teaching.Interface.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Notifier notifier;
            Worker worker = new Worker();

            Random random = new Random();

            for (int i = 0; i < 50; i++)
            {
                notifier = GetRandomNotifier(random);
                worker.Execute(notifier);
            }
            Console.Read();
        }

        private static Notifier GetRandomNotifier(Random random)
        {
            int randomNumber = random.Next(0, 100);
            if (randomNumber % 3 == 2)
            {
                return new SmsNotifier();
            }
            else if (randomNumber % 3 == 1) 
            {
                return new EmailNotifier();
            }
            else
            {
                return new Notifier();
            }
        }
    }
}
