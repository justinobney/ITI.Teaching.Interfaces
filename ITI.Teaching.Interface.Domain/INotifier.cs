namespace ITI.Teaching.Interface.Domain
{
    public interface INotifier
    {
        string Address { get; set; }
        string Message { get; set; }
        string DoWork();
    }
}