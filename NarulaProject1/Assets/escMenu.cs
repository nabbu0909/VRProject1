using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        OnMouseUp();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseUp(){
        Application.Quit();
    }
}
