using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject meteorPrefab;

    [SerializeField]
    private float delayMinimum;
    
    [SerializeField]
    private float delayMaximum;

    private float difficultyDelayFactor = 5.0f;
    private float meteorScale = 1.0f;

    public void Start()
    {
        StartCoroutine("InitiateSpawners");
        StartCoroutine("IncreaseMeteorScale");
    }

    public IEnumerator InitiateSpawners()
    {
        while(true)
        {
            StartCoroutine("Spawn");
            yield return new WaitForSeconds(Random.Range(delayMinimum, delayMaximum) * difficultyDelayFactor);

            if(difficultyDelayFactor > 1.0f)
            {
                difficultyDelayFactor -= 0.1f;
            }
        }
    }

    public IEnumerator IncreaseMeteorScale()
    {
        while(true)
        {
            yield return new WaitForSeconds(10);
            meteorScale *= 1.1f;
        }
    }

    public IEnumerator Spawn()
    {
        while(true)
        {
            yield return new WaitForSeconds(Random.Range(delayMinimum, delayMaximum));

            if(Random.value < 0.25f)
            {
                SpawnMeteorOnPlayer();
            }
            else
            {
                SpawnMeteorRandom();
            }
        }
    }

    public void SpawnMeteorOnPlayer()
    {
        GameObject[] playerObjects = GameObject.FindGameObjectsWithTag("Player");

        Vector3 spawnPosition = playerObjects[Random.Range(0, playerObjects.Length)].transform.position;
        spawnPosition += (Vector3.up * 60);

        SpawnMeteor(spawnPosition);
    }

    public void SpawnMeteorRandom()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-40f, 40f), 60, Random.Range(-20f, 20f));

        SpawnMeteor(spawnPosition);    
    }

    public void SpawnMeteor(Vector3 spawnPosition)
    {
        GameObject meteor = Instantiate(meteorPrefab, spawnPosition, Quaternion.identity);
        meteor.transform.localScale *= meteorScale;
    }
}
