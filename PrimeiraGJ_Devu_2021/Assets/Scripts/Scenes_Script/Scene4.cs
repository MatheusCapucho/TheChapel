using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene4 : GameFlow
{
    public Animator anim;
    void Start()
    {
        prologueScenes++;
        anim.SetBool("Fade", false);
    }

    public void NextScene()
    {
        StartCoroutine(Next());
    }

    public void fade()
    {
        anim.SetBool("Fade", true);
    }

    IEnumerator Next()
    {
        anim.SetBool("Fade", true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(prologueScenes);
    }
}
