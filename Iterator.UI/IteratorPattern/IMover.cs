namespace Iterator.UI.IteratorPattern
{
    public interface IMover<T>
    {
        IIterator<T> CreateIterator();
    }
}
