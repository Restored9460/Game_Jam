using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExistanceCheck : MonoBehaviour
{
    [SerializeField] GameObject beet;
    [SerializeField] GameObject bowl;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (GameObject.FindGameObjectsWithTag("Beetroot").Length == 0)
        {
            Instantiate(beet, new Vector3(-12.5f, 3, 8),Quaternion.identity);
            Instantiate(beet, new Vector3(-12, 3, 7), Quaternion.identity);
            Instantiate(beet, new Vector3(-12.5745f, 3, 7.01f), Quaternion.identity);
        }

        if (GameObject.FindGameObjectsWithTag("emptyBowl").Length == 0)
        {
            Instantiate(bowl, new Vector3(-4.5652f, 2.5f, -8.3123f), Quaternion.identity);
            Instantiate(bowl, new Vector3(-4.5652f, 3.0f, -8.3123f), Quaternion.identity);
            Instantiate(bowl, new Vector3(-4.5652f, 3.5f, -8.3123f), Quaternion.identity);
        }


    }
}
