using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene4 : MonoBehaviour
{
    public Animator anim;
    void Start()
    {
        anim.SetBool("Fade", false);
    }

}
