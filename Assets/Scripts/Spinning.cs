using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinning : MonoBehaviour
{
    // Update is called once per frame
    public float amp;
    public float speed;
    void Update()
    {
        transform.Rotate(0f, speed * Time.deltaTime, speed * Time.deltaTime, Space.Self);
        transform.position = new Vector3(397, Mathf.Sin(Time.time)* amp, -11);
    }
}
