using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointConunter : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Order")
        {
            ScoreManager.instance.AddPoint();
        }
    }
}

