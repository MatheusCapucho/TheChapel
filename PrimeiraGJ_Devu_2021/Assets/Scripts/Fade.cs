using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour
{

    private Animator anim;
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    void Start()
    {
        if(SceneManager.GetActiveScene().buildIndex != 5)   
        anim.SetBool("Fade", false);
    }

    public void FadeIN()
    {
        anim.SetBool("Fade", true);
    }
}
