namespace ITI.Teaching.Interface.Domain
{
    public class Worker
    {
        public string Execute(INotifier notifier)
        {
            string message = notifier.DoWork();
            return message;
        }
    }
}