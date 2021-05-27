using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene1_prologue : GameFlow
{
    public AudioSource audioSrc;
    public AudioClip[] audioClip;

    private int count = 0;
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        prologueScenes++;

        StartCoroutine(Prologo());

    }

    IEnumerator Prologo()
    {
        audioSrc.PlayOneShot(audioClip[count]); count++;
        yield return new WaitForSeconds(1f); // tempo relativo a todos os audios da mila

        //fade to black
        yield return new WaitForSeconds(1f);
        //audio do carro e mila
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(prologueScenes);

    }
}
