using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            transform.position += transform.forward * Time.deltaTime * speed;        
        }
        else if(Input.GetKey(KeyCode.S)){
            transform.position -= transform.forward * Time.deltaTime * speed;        
        }
        if(Input.GetKey(KeyCode.A)){
            transform.RotateAround(transform.position, transform.up, Time.deltaTime * -rotationSpeed);
        }
        if(Input.GetKey(KeyCode.D)){
            transform.RotateAround(transform.position, transform.up, Time.deltaTime * rotationSpeed);
        }
    }
}
