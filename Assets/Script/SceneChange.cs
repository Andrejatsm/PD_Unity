using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
   public void FirstScene()
    {
        SceneManager.LoadScene("FirstScene", LoadSceneMode.Single);

    }

    public void SecondScene()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    public void quit()
    {
        Application.Quit();
    }
}
