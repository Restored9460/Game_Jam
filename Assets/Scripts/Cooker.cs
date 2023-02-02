using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooker : MonoBehaviour
{
    public GameObject potSoup;
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
        if (other.tag == "CutBeetroot")
        {
            Instantiate(potSoup, new Vector3(-12.5038f, 1.2625f, -0.5151f), Quaternion.identity);
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
