
public interface ISubject 
{
    void Register(IObserver observer);
    void Deregister(IObserver observer);
    void Notify();
}
