using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    

    void OnCollisionEnter(Collision collision)
    {
        //the tag of whoever to be effect here
        if (collision.gameObject.name == "Order")
        {
            
            GameObject varGameObject = GameObject.FindWithTag("Customer");
            varGameObject.GetComponent<Navigation>().enabled = true;
            varGameObject.GetComponent<CustomerKiller>().enabled = false;
           
        }

    }
}
