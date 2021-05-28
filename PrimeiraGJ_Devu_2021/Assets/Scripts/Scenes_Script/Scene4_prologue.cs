using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene4_prologue : GameFlow
{
    public Animator animFade;
    public GameObject[] audioPlay;
    private int count = 0;

    private void Start()
    {
        prologueScenes++;
        StartCoroutine(PlayAudios());
    }

    IEnumerator PlayAudios()
    {
        audioPlay[count].SetActive(true); count++;
        yield return new WaitForSeconds(1f); // passos

        audioPlay[count].SetActive(true); count++; 
        yield return new WaitForSeconds(1f); // porta

        audioPlay[count].SetActive(true); count++;
        yield return new WaitForSeconds(8f); // estranho

        audioPlay[count].SetActive(true); count++;
        yield return new WaitForSeconds(15f); // bem recebida

        animFade.SetBool("Fade", false);

        audioPlay[count].SetActive(true); count++;
        yield return new WaitForSeconds(10f); //preciso dormir

    }

    public void Dormir()
    {
        StartCoroutine(FuiDormir());
    }

    IEnumerator FuiDormir()
    {
        audioPlay[count].SetActive(true); count++;
        yield return new WaitForSeconds(1f); //coracao
        audioPlay[count].SetActive(true); count++;
        yield return new WaitForSeconds(2f); //olhos

        animFade.SetBool("Fade", true);

        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene(prologueScenes);

    }

}
