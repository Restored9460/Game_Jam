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
     
        transform.Translate(Vector3.Normalize(target.position - transform.position) * step);

    }
    void OnCollisionEnter(Collision collision)
    {
         if (collision.gameObject.name == "CubeofDeath")
        {
            Order.transform.position = Reset.transform.position;
        }
    }

}
