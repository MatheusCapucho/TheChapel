using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CenaFinal : MonoBehaviour
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
        anim.SetBool("Fade", true);
        yield return new WaitForSeconds(1f);
        audios[count].SetActive(true); count++;
        yield return new WaitForSeconds(6.7f);
        audios[count].SetActive(true); count++;
        yield return new WaitForSeconds(7.5f);
        audios[count].SetActive(true); count++;
        yield return new WaitForSeconds(10.4f);
        audios[count].SetActive(true); count++;
        yield return new WaitForSeconds(10.3f);
        SceneManager.LoadScene("FinalCorrendo");
    }

}
