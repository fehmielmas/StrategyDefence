using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{
    [SerializeField] private GameObject palPrefab;
    
    [SerializeField] private bool isPlaceable; 
    public bool IsPlaceable { get { return isPlaceable; } }
    public bool GetIsPlaceable()
    {
        return isPlaceable;
    }
    private void OnMouseDown()
    {
        if(isPlaceable)
        {
            Instantiate(palPrefab, transform.position, Quaternion.identity);
            isPlaceable = false;
        }
    }
}
