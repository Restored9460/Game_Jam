using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation : MonoBehaviour
{
    public Transform Reset;
    public GameObject Order;

    public Transform target;
    public float step = 1.0f;
  
    public void Update()
    {
        // this makes him run
     
        transform.Translate(Vector3.Normalize(target.position - transform.position) * step);

    }
    void OnCollisionEnter(Collision collision)
    {
        // same if codes used as before
         if (collision.gameObject.name == "CubeofDeath")
        {
            Order.transform.position = Reset.transform.position;
        }
    }

}
