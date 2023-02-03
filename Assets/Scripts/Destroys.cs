using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroys : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.name == "Order")
        {
            // this makes him stop
            GameObject varGameObject = GameObject.FindWithTag("Customer");
            varGameObject.GetComponent<Navigation>().enabled = false;
           
            
        }
        if (collision.gameObject.tag == "Flour")
        {
            Destroy(collision.gameObject);
        }

        //change the tag here to make the npc to other food has to be a tab btw
        if (collision.gameObject.tag == "Flour" || collision.gameObject.tag == "Bowl")
        {
            
            
                GameObject varGameObject = GameObject.FindWithTag("Customer");
                varGameObject.GetComponent<CustomerKiller>().enabled = true;
                Debug.Log("works");
            
        }
    }
}