using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OperDoor : GameFlow
{

    public void OpenVelha()
    {
        if (olhoVermelho == false)
        {
            SceneManager.LoadScene(11); // minigame feto
        }
    }

    public void OpenMaluco()
    {
        if (olhoAmarelo == false)
        {
            SceneManager.LoadScene(10); // minigame charada
        }
    }

    public void OpenJoel()
    {
        if (olhoVerde == false)
        {
            SceneManager.LoadScene(12); // minigame tocha
        }
    }

}
