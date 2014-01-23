using System;

namespace ITI.Teaching.Interface.Domain
{
    public class EmailNotifier : Notifier
    {
        public string Address { get; set; }
        public string Message { get; set; }

        public override string DoWork()
        {
            Console.WriteLine("Sending Email:");
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Message: " + Message);
            return String.Format("EMAIL:{0}|{1}", Address, Message);
        }
    }
}