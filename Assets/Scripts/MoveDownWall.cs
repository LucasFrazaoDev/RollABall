using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDownWall : MonoBehaviour
{
    private float smoothTime = 0.5f;
    private Vector3 velocity = Vector3.down;

    private void Update()
    {
        transform.localPosition = Vector3.SmoothDamp(transform.position, new Vector3(0, -5, 10), ref velocity, smoothTime);
    }

    /* 
    Vector3.Lerp interpolates a linear value between two Vector3 type values with a float value from 0 to 1,
    Vector.SmoothDamp uses 3 Vector3 type values (start position, end position, velocity direction) and a float value
    with the duration of the runtime.
     */
}
