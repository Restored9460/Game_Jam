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
        if (collision.gameObject.tag == "Sandwich")
        {
         // beetroot and dough spawns
        }
        if (collision.gameObject.tag == "Soup")
        {
            //nowl and beetroot spawns
        }
        if (collision.gameObject.tag == "PotBeet")
        {
//pot and beetroot spawns
        }

        //change the tag here to make the npc to other food has to be a tab btw
        if (collision.gameObject.tag == "Finish" || collision.gameObject.tag == "Soup" || collision.gameObject.tag == "PotBeet")
        {
            
            
                GameObject varGameObject = GameObject.FindWithTag("Customer");
                varGameObject.GetComponent<CustomerKiller>().enabled = true;
                
        }
    }
}