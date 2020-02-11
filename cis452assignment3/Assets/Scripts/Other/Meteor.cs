/*
* Evan Meyer
* Meteor.cs
* CIS452 Assignment 3
*/

using UnityEngine;

public class Meteor : MonoBehaviour
{
    [SerializeField]
    private GameObject explosionPrefab;

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Floor"))
        {
            Destroy(gameObject);
        }
    }

    public void OnDestroy()
    {
        GameObject explosion = Instantiate(explosionPrefab, gameObject.transform.position, Quaternion.identity);
        explosion.transform.localScale = gameObject.transform.localScale;
        Destroy(explosion, 3);
    }
}
