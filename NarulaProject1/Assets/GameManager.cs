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
        Cursor.lockState = CursorLockMode.Locked;
        exitText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {   
        if (Time.timeSinceLevelLoad < 60){
            if(Input.GetKeyDown("e")){
                projSpeed += speedIncrement;
            }
            if(Input.GetKeyDown("q")){
                projSpeed -= speedIncrement;
            }
            if(Input.GetMouseButtonDown(0) && !exitText.IsActive()) {
                Proj = Instantiate<GameObject>(ProjPrefab);
                Proj.transform.position = player.transform.position + Camera.main.transform.forward;
                Rigidbody rb = Proj.GetComponent<Rigidbody>();
                rb.velocity = Camera.main.transform.forward * projSpeed;
            }

            if(Input.GetKeyDown(KeyCode.Escape) && exitText.IsActive()) {
                Cursor.lockState = CursorLockMode.Locked;
                exitText.gameObject.SetActive(false);
            }
            else if (Input.GetKeyDown(KeyCode.Escape)) {
                Cursor.lockState = CursorLockMode.Confined;
                exitText.gameObject.SetActive(true);
            }
        }
        else {
            finalScore.text = "Score: " + goal.pointsMade;
            Cursor.lockState = CursorLockMode.Confined;
            exitText.gameObject.SetActive(true);
        }
        counter.text = "Throw Speed: " + projSpeed;
    }
}
