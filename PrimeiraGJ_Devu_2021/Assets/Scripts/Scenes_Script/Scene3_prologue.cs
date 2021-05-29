using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene3_prologue : GameFlow
{

    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void Start()
    {
        anim.SetBool("Fade", false);
        prologueScenes = 4;
    }

    public void NextScene()
    {
        StartCoroutine(ProximaCena());
    }
    
    IEnumerator ProximaCena()
    {

        anim.SetBool("Fade", true);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(prologueScenes);

    }
}
