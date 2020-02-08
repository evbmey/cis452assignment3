
public interface IObserver<T> 
{
    void React(T param);
}

public interface IObserver<T1, T2>
{
    void React(T1 param1, T2 param2);
}

