using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiNoClip : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
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
}
