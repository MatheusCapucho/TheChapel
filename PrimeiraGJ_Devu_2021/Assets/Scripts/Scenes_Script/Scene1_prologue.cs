using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene1_prologue : GameFlow
{
    public Animator imageFade;
    public GameObject[] audioHandler;

   // private int count = 0;

    private void Awake()
    {
  
    }
    void Start()
    {
        prologueScenes++;
        
        StartCoroutine(Prologo());
    }

    IEnumerator Prologo()
    {
        //audioHandler[count].GetComponent<AudioHandler>().audioSrc.Play(); count++;
        yield return new WaitForSeconds(1f);
       // audioHandler[count].GetComponent<AudioHandler>().audioSrc.Play(); count++;
        yield return new WaitForSeconds(1f);


        yield return new WaitForSeconds (5f);

        imageFade.SetBool("Fade", true);

        yield return new WaitForSeconds(5f);

        SceneManager.LoadScene(prologueScenes);
    }


}
