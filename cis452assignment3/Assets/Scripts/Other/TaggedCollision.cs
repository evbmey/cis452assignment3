/*
* Evan Meyer
* TaggedCollision.cs
* CIS452 Assignment 3
*/

using UnityEngine;
using UnityEngine.Events;

public class TaggedCollision : MonoBehaviour
{
    [SerializeField]
    private UnityEvent onTaggedCollision;

    [SerializeField]
    private string[] tags;

    public void OnCollisionEnter(Collision collision)
    {
        bool hasTag = false;

        foreach(string tag in tags)
        {
            if(collision.gameObject.CompareTag(tag))
            {
                hasTag = true;
            }
        }

        if(hasTag)
        {
            onTaggedCollision?.Invoke();
        }
    }
}
