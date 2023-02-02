using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakingSoup : MonoBehaviour
{
    public GameObject potWater;
    public GameObject beetSoup;
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
        if (other.tag == "emptyBowl")
        {
            Instantiate(potWater, new Vector3(-12.5038f, 1.2625f, -0.5151f), Quaternion.identity);
            Instantiate(beetSoup, new Vector3(-12.5038f, 2.6362f, 1.3534f), Quaternion.identity);
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
