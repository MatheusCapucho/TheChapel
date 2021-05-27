using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene1_prologue : GameFlow
{
    private Animator anim;
    public GameObject[] audioHandler;

    private int count = 0;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    void Start()
    {
        prologueScenes++;
        StartCoroutine(Prologo());
    }

    IEnumerator Prologo()
    {
        audioHandler[count].GetComponent<AudioHandler>().audioSrc.Play(); count++;
        audioHandler[count].GetComponent<AudioHandler>().audioSrc.Play(); count++;


        //SceneManager.LoadScene(prologueScenes);
        yield return new WaitForSeconds (1f);
    }
}
