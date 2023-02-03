using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttingBoard : MonoBehaviour
{
    public GameObject cut;
    public GameObject sandwich;
    bool Beet = false;
    bool Bread = false;
    // Start is called before the first frame update


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Beetroot")
        {
            Instantiate(cut, new Vector3(-7.576188f, 3, -8.3123f), Quaternion.identity);
            other.tag = "forSandwich";
            Destroy(other.gameObject);
        }

        if (other.tag == "Finish")
        {
            Bread = true;
            other.tag = "forSandwich";
        }

        if (other.tag == "cookedBeetroot")
        {
            Beet = true;
            other.tag = "forSandwich";
        }
    }

    private void Update()
    {
        if (Beet == true && Bread == true)
        {
            Instantiate(sandwich, new Vector3(-7.576188f, 3, -8.3123f), Quaternion.identity);
            Beet = false;
            Bread = false;
            GameObject[] ingred = GameObject.FindGameObjectsWithTag("forSandwich");
            foreach (GameObject forSandwich in ingred)
                GameObject.Destroy(forSandwich);
        }
    }
}
