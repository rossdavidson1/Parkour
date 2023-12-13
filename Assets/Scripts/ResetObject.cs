using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetObject : MonoBehaviour
{
    private Vector3 originalPosition;

    void Start()
    {
        // Store the original position when the script starts
        originalPosition = transform.position;
    }

    void Update()
    {
        // Check if a specific key is pressed (e.g., 'R')
        if (Input.GetKeyDown(KeyCode.R))
        {
            // Reset the object's position to the original position
            transform.position = originalPosition;
        }
    }
}
