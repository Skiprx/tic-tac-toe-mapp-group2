using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour {

    public void StartGame()
    {
        Application.LoadLevel("Main");
    }

    public void OpenMenu()
    {
        Application.LoadLevel("Menu");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
