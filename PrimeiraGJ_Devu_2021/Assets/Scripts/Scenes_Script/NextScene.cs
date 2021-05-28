using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : GameFlow
{

    public Animator anim;

    private void Start()
    {
        anim.SetBool("Fade", false);
    }

    public void ProximaCena()
    {
        prologueScenes = 5;
        StartCoroutine(Next());
    }

    IEnumerator Next()
    {
        yield return new WaitForSeconds(20f);
        anim.SetBool("Fade", true);
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(prologueScenes);
    }
 
}
