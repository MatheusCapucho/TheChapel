using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene2_prologue : GameFlow
{

    void Start()
    {
        //fade out
        prologueScenes++;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            StartCoroutine(NextScene());
        }
    }

    IEnumerator NextScene()
    {
        //fade in
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(prologueScenes);

    }

}
