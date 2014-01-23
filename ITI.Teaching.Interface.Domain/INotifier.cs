using System;
namespace ITI.Teaching.Interface.Domain
{
    public interface INotifier
    {
        string Address { get; set; }
        string Message { get; set; }
        string DoWork();
    }

    public class Notifier
    {
        public string Address { get; set; }
        public string Message { get; set; }

        public virtual string DoWork()
        {
            Console.WriteLine("Doing GENERIC Work");
            return "Bam";
        }
    }
}