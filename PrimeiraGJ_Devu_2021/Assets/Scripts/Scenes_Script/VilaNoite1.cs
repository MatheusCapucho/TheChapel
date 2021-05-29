using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VilaNoite1 : GameFlow
{
    public GameObject[] audios;
    private int count = 0;

    private static bool inicio = true;

    void Start()
    {
        if (inicio)
        {
            sceneAfterMinigame = prologueScenes + 1;
            StartCoroutine(Inicio());
        }
    }

    IEnumerator Inicio()
    {
        inicio = false;
        yield return new WaitForSeconds(5f);
        audios[count].SetActive(true); count++;
        yield return new WaitForSeconds(3f);
        audios[count].SetActive(true);

    }
}
