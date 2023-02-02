using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Movement : MonoBehaviour
{
    public CharacterController controller;
    Vector3 turnVelocity;
    public float rotationSpeed = 90;
    public float speed = 5f;


    

    Vector3 movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical);
        this.transform.position = new Vector3(this.transform.position.x, 2.1407f, this.transform.position.z);

        if(direction.magnitude >= 0.1f)
        {
            controller.Move(direction * speed * Time.deltaTime);
                turnVelocity = transform.up * rotationSpeed * horizontal; 
        }
        
    }
    
}
