/*
* Evan Meyer
* InputSubject.cs
* CIS452 Assignment 3
*/

using System.Collections.Generic;
using UnityEngine;

public class InputSubject : MonoBehaviour, ISubject<float, float>
{
    private List<IObserver<float, float>> observers = new List<IObserver<float, float>>();

    public void Register(IObserver<float, float> observer)
    {
        observers.Add(observer);
    }

    public void Deregister(IObserver<float, float> observer)
    {
        observers.Remove(observer);
    }

    public void Notify(float x, float y)
    {
        foreach(IObserver<float, float> observer in observers)
        {
            observer?.React(x, y);
        }
    }

    public void FixedUpdate()
    {
        Notify(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

}
