using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public Button exitText;
    public float speedIncrement;
    public GameObject player;
    public Goal goal;

    public GameObject ProjPrefab;
    public GameObject Proj;
    public Text counter;
    public Text finalScore;
    public float projSpeed;
    // Start is called before the first frame update
    void Start()
    {
        //set cursor state
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        exitText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {   
        //game timer
        if (Time.timeSinceLevelLoad < 60){
            //increase throw power
            if(Input.GetKeyDown("e")){
                projSpeed += speedIncrement;
            }
            //decrease throw power
            if(Input.GetKeyDown("q")){
                projSpeed -= speedIncrement;
            }
            //throw ball
            if(Input.GetMouseButtonDown(0) && !exitText.IsActive()) {
                Proj = Instantiate<GameObject>(ProjPrefab);
                Proj.transform.position = player.transform.position + Camera.main.transform.forward;
                Rigidbody rb = Proj.GetComponent<Rigidbody>();
                rb.velocity = Camera.main.transform.forward * projSpeed;
            }

            //menu
            if(Input.GetKeyDown(KeyCode.Escape) && exitText.IsActive()) {
                Cursor.lockState = CursorLockMode.Locked;
                exitText.gameObject.SetActive(false);
            }
            //close menu
            else if (Input.GetKeyDown(KeyCode.Escape)) {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.Confined;
                exitText.gameObject.SetActive(true);
            }
        }
        //time's up
        else {
            Cursor.visible = true;
            finalScore.text = "Score: " + goal.pointsMade;
            Cursor.lockState = CursorLockMode.Confined;
            exitText.gameObject.SetActive(true);
        }
        //display throw speed
        counter.text = "Throw Speed: " + projSpeed;
    }
}
