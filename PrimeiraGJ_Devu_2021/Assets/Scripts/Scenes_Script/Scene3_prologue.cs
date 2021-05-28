using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    }

    public void NextScene()
    {
        StartCoroutine(ProximaCena());
    }
    
    IEnumerator ProximaCena()
    {

        anim.SetBool("Fade", true);
        yield return new WaitForSeconds(1f);
    }
}
