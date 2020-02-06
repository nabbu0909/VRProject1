using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    public Transform goal;
    public Text score;
    public float pointsMade = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + pointsMade;
    }
    private void OnTriggerEnter(Collider other)
    {
        pointsMade++;
        Destroy(other.gameObject);
        goal.position = new Vector3(Random.Range(-50.0f, 50.0f), -0.3f, Random.Range(-50.0f, 50.0f));
    }
}
