using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ITI.Teaching.Interface.Domain
{
    public class SmsNotifier : Notifier
    {
        public string Address { get; set; }
        public string Message { get; set; }

        public override string DoWork()
        {
            Console.WriteLine("Sending SMS:");
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Message: " + Message);
            return String.Format("SMS:{0}|{1}", Address, Message);
        }
    }
}
