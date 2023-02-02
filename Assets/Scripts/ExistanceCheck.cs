using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExistanceCheck : MonoBehaviour
{
    [SerializeField] GameObject beet;
    [SerializeField] GameObject bowl;
    [SerializeField] GameObject flour;
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

        if (GameObject.FindGameObjectsWithTag("Flour").Length == 0)
        {
            Instantiate(flour, new Vector3(-12.54926f, 2.4543f, -6.8579f), Quaternion.identity);
            Instantiate(flour, new Vector3(-12.67956f, 2.4745f, -5.857662f), Quaternion.identity);
            Instantiate(flour, new Vector3(-11.91662f, 2.5048f, -5.328232f), Quaternion.identity);
        }

    }
}
