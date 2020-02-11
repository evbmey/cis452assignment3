/*
* Evan Meyer
* InputObserver.cs
* CIS452 Assignment 3
*/

using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class InputObserver : MonoBehaviour, IObserver<float, float>
{
    public float speed;

    [SerializeField]
    private InputSubject subject;

    private new Rigidbody rigidbody;

    public void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    public void Start()
    {
        subject?.Register(this);
    }

    public void OnDestroy()
    {
        subject?.Deregister(this);
    }

    public void React(float x, float z)
    {
        rigidbody.AddForce(new Vector3(x, 0, z) * speed);
    }
}
