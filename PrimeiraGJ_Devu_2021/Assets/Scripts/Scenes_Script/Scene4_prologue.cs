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
        animFade.SetBool("Fade", true);
    }

    IEnumerator PlayAudios()
    {
        audioPlay[count].SetActive(true);
        yield return new WaitForSeconds(5f); // passos
        audioPlay[count].SetActive(false); count++;

        audioPlay[count].SetActive(true); count++; 
        yield return new WaitForSeconds(5f); // porta

        audioPlay[count].SetActive(true); count++;
        yield return new WaitForSeconds(5.4f); // estranho

        audioPlay[count].SetActive(true); count++;
        yield return new WaitForSeconds(0.01f); // caderno
        audioPlay[count].SetActive(true); count++;
        yield return new WaitForSeconds(23f); //preciso dormir

        animFade.SetBool("Fade", false);
    }

    public void Dormir()
    {
        StartCoroutine(FuiDormir());
    }

    IEnumerator FuiDormir()
    {
        audioPlay[count].SetActive(true); count++;
        yield return new WaitForSeconds(7f); //coracao

        animFade.SetBool("Fade", true);

        audioPlay[count].SetActive(true); count++;
        yield return new WaitForSeconds(5f); //olhos
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(prologueScenes);

    }

}
