using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLocater : MonoBehaviour
{
    [SerializeField] Transform weapon;
    [SerializeField] Transform target;
    
    void Start()
    {
        target = FindObjectOfType<EnemyMover>().transform;
    } 

    
    void Update()
    {
        AimWeapon();
        
    }

    void AimWeapon()
    {
        transform.LookAt(target);
    }
}
