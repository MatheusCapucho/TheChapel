using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene1_prologue : GameFlow
{
    public Animator imageFade;
    public GameObject[] audioHandler;

    private int count = 0;

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
        audioHandler[count].SetActive(true); count++;
        yield return new WaitForSeconds(33.4f);
        audioHandler[count].SetActive(true); count++; //mila1
        yield return new WaitForSeconds(21.5f);
        audioHandler[count].SetActive(true); count++; //mila2
        yield return new WaitForSeconds(10f);
        audioHandler[count].SetActive(true); count++; //mila3
        yield return new WaitForSeconds(5f);
        audioHandler[count].SetActive(true); count++; //pastor4
        yield return new WaitForSeconds(26f);
        audioHandler[count].SetActive(true); count++; //mila5
        yield return new WaitForSeconds(5f);
  
        imageFade.SetBool("Fade", true);
        this.gameObject.GetComponent<AudioSource>().Stop();

        yield return new WaitForSeconds(1f);

        audioHandler[count].SetActive(true); count++; //carroo6
        yield return new WaitForSeconds(2f);
        audioHandler[count].SetActive(true); count++; //carro7
        yield return new WaitForSeconds(2f);


        audioHandler[count].SetActive(true); count++; //mila a pe8
        yield return new WaitForSeconds(6f);
        audioHandler[count].SetActive(true);  //carro9
        yield return new WaitForSeconds(3f);
        audioHandler[count].SetActive(false);
        count++;
        audioHandler[count].SetActive(true); count++; //carro10
        yield return new WaitForSeconds(6f);

        SceneManager.LoadScene(prologueScenes);
    }


}
