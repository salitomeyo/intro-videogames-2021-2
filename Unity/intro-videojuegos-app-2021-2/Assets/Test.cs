using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    
    void Start()
    {
        Player.OnPlayerTakeHit += OnPlayerHit;
    }

    private void OnDestroy()
    {
        Player.OnPlayerTakeHit -= OnPlayerHit;
    }

    private void OnPlayerHit(int damage, int currentHealth)
    {
        Debug.LogError("Damage: " + damage + ", Current health: " + currentHealth);
    }
   
}
