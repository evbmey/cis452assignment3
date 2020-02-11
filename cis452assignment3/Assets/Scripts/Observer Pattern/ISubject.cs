/*
* Evan Meyer
* ISubject.cs
* CIS452 Assignment 3
*/

public interface ISubject<T> 
{
    void Register(IObserver<T> observer);
    void Deregister(IObserver<T> observer);
    void Notify(T param);
}

public interface ISubject<T1, T2>
{
    void Register(IObserver<T1, T2> observer);
    void Deregister(IObserver<T1, T2> observer);
    void Notify(T1 param1, T2 param2);
}