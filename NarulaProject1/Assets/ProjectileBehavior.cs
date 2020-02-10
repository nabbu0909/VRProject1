using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    public AudioClip fireSound;
    // Start is called before the first frame update
    void Start()
    {
        //fire ball sound
        AudioSource.PlayClipAtPoint(fireSound, transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
