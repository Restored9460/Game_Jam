using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnaceToBread : MonoBehaviour
{
    public GameObject bread;
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
        if (other.tag == "Dough")
        {
            Instantiate(bread, new Vector3(-3.1815f, 1.5f, 7.3124f), Quaternion.identity);
            Destroy(other.gameObject);
        }
    }
}
