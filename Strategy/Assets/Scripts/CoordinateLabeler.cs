using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[ExecuteAlways]
public class CoordinateLabeler : MonoBehaviour
{
    [SerializeField] private Color defaultColor = Color.black;
    [SerializeField] private Color blockedColor = Color.white;

    private TextMeshPro label;
    private Vector2Int coordinates = new Vector2Int();
    private WayPoint wayPoint;

    void Awake()
    {
        label = GetComponent<TextMeshPro>();
        label.enabled = false;

        wayPoint = GetComponentInParent<WayPoint>();
        DisplayCoordinates();
    }

    private void Update()
    {
        if (!Application.isPlaying)
        {
            DisplayCoordinates();
            UpdateObjectName();
        }

        ColorCoordinates();
        ToggleLabels();
    }

    void ToggleLabels()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            label.enabled = !label.enabled;
        }
    }

    void ColorCoordinates()
    {
        if (wayPoint != null)
        {
            if (wayPoint.IsPlaceable)
            {
                label.color = defaultColor;
            }
            else
            {
                label.color = blockedColor;
            }
        }
    }

    void DisplayCoordinates()
    {
        coordinates.x = Mathf.RoundToInt(transform.parent.position.x / UnityEditor.EditorSnapSettings.move.x);
        coordinates.y = Mathf.RoundToInt(transform.parent.position.z / UnityEditor.EditorSnapSettings.move.z);
        label.text = coordinates.x + "," + coordinates.y;
    }

    void UpdateObjectName()
    {
        transform.parent.name = coordinates.x + ", " + coordinates.y;
    }
}