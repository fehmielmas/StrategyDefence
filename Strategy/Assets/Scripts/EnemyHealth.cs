using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int maxHitPoints = 10;
    [SerializeField] int currentHitPoints = 0;
    
    void Start()
    {
        currentHitPoints = maxHitPoints;
    }

    private void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    void ProcessHit()
    {
        currentHitPoints--;

        if (currentHitPoints <= 0)
        {
            Destroy(gameObject);
        }
    }
    
}
