using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food_Pickup : MonoBehaviour
{
    public GameObject FoodOnPlayer;



    // Start is called before the first frame update
    void Start()
    {
        FoodOnPlayer.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                this.gameObject.SetActive(false);

                FoodOnPlayer.SetActive(true);
            }
        }
    }

}
