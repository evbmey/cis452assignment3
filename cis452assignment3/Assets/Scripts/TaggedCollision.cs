using UnityEngine;
using UnityEngine.Events;

public class TaggedCollision : MonoBehaviour
{
    [SerializeField]
    private UnityEvent unityEvent;

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
            unityEvent?.Invoke();
        }
    }
}
