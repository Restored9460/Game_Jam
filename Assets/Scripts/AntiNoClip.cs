using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiNoClip : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Awake()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.y < -2)
        {
            this.transform.position = new Vector3(this.transform.position.x, 2, this.transform.position.z);
        }
      
           
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "outOfMap")
        {
            this.transform.position = new Vector3(2, 2, 2);
        }
    }
}
