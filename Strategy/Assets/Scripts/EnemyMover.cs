using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private List<WayPoint> path = new List<WayPoint>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void PrintWaypointName()
    {
        foreach (WayPoint wayPoint in path)
        {
            Debug.Log(wayPoint.name);
        }
    }
}
