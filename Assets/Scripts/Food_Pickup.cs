using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food_Pickup : MonoBehaviour
{

    public GameObject Food;



    void Start()
    {
        Food.SetActive(false);
    }

    

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                this.gameObject.SetActive(false);
                Food.SetActive(true);
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.F))
            {
                Instantiate(Food, transform.position, transform.rotation);
                Debug.Log("Object created?");
            }
        }
    }
}
