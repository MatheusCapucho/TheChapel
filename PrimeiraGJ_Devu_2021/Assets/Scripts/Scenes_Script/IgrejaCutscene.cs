using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IgrejaCutscene : GameFlow
{

    public Animator anim;

    public void proximaCena(float tempoAudio)
    {
        StartCoroutine(Next(tempoAudio));
    }

    IEnumerator Next(float i)
    {
        prologueScenes = 8;
        yield return new WaitForSeconds(i);
        anim.SetBool("Fade", true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(prologueScenes);
    }

}
