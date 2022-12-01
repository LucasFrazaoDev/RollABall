using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ferry : MonoBehaviour
{
    [SerializeField] private float speed;

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.PingPong(Time.time * speed, 1) * 12 - 6;
        transform.localPosition = new Vector3(x, 0, -1);
    }
}
