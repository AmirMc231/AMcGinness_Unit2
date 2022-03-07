using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    private float horz; //horizontal input variable
    private float vert; //vertical input variable
    private float Hspeed = 20.0f;
    private float xRange = 22.0f; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horz = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horz * Time.deltaTime * Hspeed);

        if (transform.position.x > 22)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x < -22)
            {
                transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
            }
        
        
    }
}
