using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFlow : MonoBehaviour
{
    
    public static int sceneAfterMinigame = 0; // ver na build o valor inicial
    public static bool olhoVermelho = false;
    public static bool olhoAmarelo = false;
    public static bool olhoVerde = false;
    public static int prologueScenes = 1;

    public static int missaVelha = 0; //build index. mudar;
    public static int missaJoel = 0;
    public static int missaPatrick = 0;


    public void CenaDePuzzle()
    {
        if (olhoAmarelo)
        {
            if (olhoVermelho)
            {
                SceneManager.LoadScene(0); // num da build da cena que só a casa do olho verde esta disponivel
            } else
            {
                //
            }
        } else if (olhoVerde)
        {
            if (olhoAmarelo)
            {
                //
            }
            else
            {
                //
            }
        } else if (olhoVermelho)
        {
            if (olhoVerde)
            {
                //
            } 
            else
            {
                //
            }
        }
    }

}
