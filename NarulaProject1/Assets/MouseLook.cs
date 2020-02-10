using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity;
    public float clampAngle;
    
    private float rotationX;
    private float rotationY; 
    // Start is called before the first frame update
    void Start()
    {
        //set variables
        Vector3 rot = transform.localRotation.eulerAngles;
        rotationY = rot.y;
        rotationX = rot.x;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = -Input.GetAxis("Mouse Y");
 
        //set mouse rotation
        rotationY += mouseX * mouseSensitivity * Time.deltaTime;
        rotationX += mouseY * mouseSensitivity * Time.deltaTime;
 
        //clamp rotation location
        rotationX = Mathf.Clamp(rotationX, -clampAngle, clampAngle);
 
        //apply rotation
        Quaternion totalRotation = Quaternion.Euler(rotationX, rotationY, 0.0f);
        transform.rotation = totalRotation;
    }
}
