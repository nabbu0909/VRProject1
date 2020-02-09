using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public void beginGame()
    {
        Debug.Log("Begin Game");
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }
    public void quitGame()
    {
        Debug.Log("End Game");
        Application.Quit();
    }
}
