namespace ITI.Teaching.Interface.Domain
{
    public class Worker
    {
        public string Execute(Notifier notifier)
        {
            string message = notifier.DoWork();
            return message;
        }
    }
}