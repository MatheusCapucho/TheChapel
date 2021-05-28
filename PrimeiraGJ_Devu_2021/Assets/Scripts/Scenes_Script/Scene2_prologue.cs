using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene2_prologue : GameFlow
{

    public Animator anim;


    private void Start()
    {

        prologueScenes++;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("PlayerM"))
        {
            StartCoroutine(NextScene());
        }
    }

    IEnumerator NextScene()
    {
        anim.SetBool("Fade", true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(prologueScenes);

    }

}
