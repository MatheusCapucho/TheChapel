using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalCarro : MonoBehaviour
{
    public Animator anim;

    public GameObject[] audios;

    private int count = 0;

    void Start()
    {
        StartCoroutine(RoteiroCenaFinal());
    }


    IEnumerator RoteiroCenaFinal()
    {
        anim.SetBool("Fade", false);
        yield return new WaitForSeconds(1f);
        audios[count].SetActive(true); count++;
        yield return new WaitForSeconds(11f);
        audios[count].SetActive(true); count++;
        yield return new WaitForSeconds(3.8f);
        audios[count].SetActive(true); count++;
        yield return new WaitForSeconds(6f);

        anim.SetBool("Fade", true);

        yield return new WaitForSeconds(2f);

        SceneManager.LoadScene(0);
    }
}
