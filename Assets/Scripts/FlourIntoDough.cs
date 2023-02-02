using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlourIntoDough : MonoBehaviour
{
    public GameObject dough;
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
        if (other.tag == "Flour")
        {
            Instantiate(dough, new Vector3(0.8686004f, 3, -8.3123f), Quaternion.identity);
            Destroy(other.gameObject);
        }
    }
}
