using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public Transform objectToMove; 
    public Transform targetPoint; 
    public float moveSpeed = 5.0f;

    void Update()
    {
        float step = moveSpeed * Time.deltaTime; 
        objectToMove.position = Vector3.MoveTowards(objectToMove.position, targetPoint.position, step);
    }
}
