/*
* Evan Meyer
* Splitter.cs
* CIS452 Assignment 3
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Splitter : MonoBehaviour
{
    [SerializeField]
    private float minimumScale;

    [SerializeField]
    private float splitFactor;

    private new Rigidbody rigidbody;

    public void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    public void Split()
    {
        gameObject.transform.localScale *= splitFactor;
        rigidbody.mass *= splitFactor;

        if(gameObject.transform.localScale.x < minimumScale ||
           gameObject.transform.localScale.y < minimumScale ||
           gameObject.transform.localScale.z < minimumScale)
        {
            Destroy(gameObject);
        }
        else
        {
            Instantiate(this);
        }
    }
}
