using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExistanceCheck : MonoBehaviour
{
    [SerializeField] GameObject beet;
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




    }
}
