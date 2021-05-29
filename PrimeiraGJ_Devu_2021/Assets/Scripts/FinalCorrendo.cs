using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalCorrendo : MonoBehaviour
{
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("Fade", false) ;
        StartCoroutine(Cena());
    }

    IEnumerator Cena()
    {
        yield return new WaitForSeconds(45f);
        anim.SetBool("Fade", true); yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("FinalScene");
    }
    
}
