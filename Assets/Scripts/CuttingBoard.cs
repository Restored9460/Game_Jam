using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttingBoard : MonoBehaviour
{
    public GameObject cut;
    // Start is called before the first frame update
     
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Beetroot")
        {
            Instantiate(cut, new Vector3(-7.576188f, 3, -8.3123f), Quaternion.identity);
            Destroy(other.gameObject);
        }
    }
}
