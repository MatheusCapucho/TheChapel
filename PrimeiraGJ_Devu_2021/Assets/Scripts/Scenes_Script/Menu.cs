using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : GameFlow
{
    public void StartGame()
    {
        SceneManager.LoadScene(prologueScenes);
    }

    public void Quitgame()
    {
        Application.Quit();
    }

}
