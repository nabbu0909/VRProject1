using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject ProjPrefab;
    public GameObject Proj;
    public Text counter;
    public float projSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("e")){
            projSpeed += 1;
        }
        if(Input.GetKeyDown("q")){
            projSpeed -= 1;
        }
        if(Input.GetMouseButtonDown(0)) {
            Proj = Instantiate<GameObject>(ProjPrefab);
            Proj.transform.position = player.transform.position + Camera.main.transform.forward;
            Rigidbody rb = Proj.GetComponent<Rigidbody>();
            rb.velocity = Camera.main.transform.forward * projSpeed;
        }
        counter.text = "Throw Speed: " + projSpeed;
    }
}
