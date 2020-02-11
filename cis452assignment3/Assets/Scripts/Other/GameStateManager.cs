/*
* Evan Meyer
* GameStateManager.cs
* CIS452 Assignment 3
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameStateManager : MonoBehaviour
{
    [SerializeField]
    private UnityEvent onAllPlayersDestroyed;

    public void Update()
    {
        if(GameObject.FindGameObjectsWithTag("Player").Length == 0)
        {
            onAllPlayersDestroyed?.Invoke();
        }
    }
}
