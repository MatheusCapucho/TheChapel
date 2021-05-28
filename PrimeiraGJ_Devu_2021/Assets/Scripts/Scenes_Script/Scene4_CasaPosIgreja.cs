using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene4_CasaPosIgreja : GameFlow
{
    public void Next()
    {
        StartCoroutine(next());           
    }

    IEnumerator next()
    {
        yield return new WaitForSeconds(27f);
        SceneManager.LoadScene(prologueScenes);

    }
}
