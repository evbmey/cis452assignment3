using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subject : MonoBehaviour, ISubject
{
    [SerializeField]
    private List<IObserver> observers;

    // Start is called before the first frame update
    public void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {

    }

    void ISubject.Register(IObserver observer)
    {
        observers.Add(observer);
    }

    void ISubject.Deregister(IObserver observer)
    {
        observers.Remove(observer);
    }

    void ISubject.Notify()
    {
        foreach (IObserver observer in observers)
        {
            observer.Update();
        }
    }
}