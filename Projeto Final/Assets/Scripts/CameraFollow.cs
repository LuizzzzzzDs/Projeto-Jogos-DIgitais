using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float minX, maxX; 
    public float minY, maxY; 
    public float timeLerp = 0.1f; 

    private void FixedUpdate()
    {

        Vector3 newPosition = player.position + new Vector3(0, 0, -10);

        
        newPosition = Vector3.Lerp(transform.position, newPosition, timeLerp);

       
        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);
        newPosition.y = Mathf.Clamp(newPosition.y, minY, maxY);

        
        transform.position = newPosition;
    }
}
