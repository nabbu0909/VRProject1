using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    //start button
    public void beginGame()
    {
        Debug.Log("Begin Game");
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }
    //quit button
    public void quitGame()
    {
        Debug.Log("End Game");
        Application.Quit();
    }
}
