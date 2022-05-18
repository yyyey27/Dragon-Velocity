using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Tutorial (Castle)");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
