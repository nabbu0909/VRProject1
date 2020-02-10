using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    public AudioClip pointSound;
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
        //score text
        score.text = "Score: " + pointsMade;
    }
    private void OnTriggerEnter(Collider other)
    {
        //update score when point made
        pointsMade++;
        AudioSource.PlayClipAtPoint(pointSound, transform.position);
        Destroy(other.gameObject);
        //reset goal to random location
        goal.position = new Vector3(Random.Range(-50.0f, 50.0f), -0.3f, Random.Range(-50.0f, 50.0f));
    }
}
