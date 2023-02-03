using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    

    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "Order")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            GameObject varGameObject = GameObject.FindWithTag("Customer");
            varGameObject.GetComponent<Navigation>().enabled = true;
            varGameObject.GetComponent<CustomerKiller>().enabled = false;
            Debug.Log("HE talking");
        }

    }
}
