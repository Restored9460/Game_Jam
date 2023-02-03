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

        //chane the tag here to make the npc to other food
        if (collision.gameObject.tag == "PotBeet")
        {

            GameObject varGameObject = GameObject.FindWithTag("Customer");
            varGameObject.GetComponent<CustomerKiller>().enabled = true;
           
        }
    }
}