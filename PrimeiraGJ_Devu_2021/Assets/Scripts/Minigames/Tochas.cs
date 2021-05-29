using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tochas : MonoBehaviour
{
    public GameObject[] image; // inspector

    private static int tochasAcesas = 2;
    
    public void ResolverTocha(int pos)
    {
        if (image[pos].activeInHierarchy)
        {
            image[pos].SetActive(false);
            tochasAcesas--;

        } else
        {
            image[pos].SetActive(true);
            tochasAcesas++;
            if (tochasAcesas == 4)
            {
                SceneManager.LoadScene("Capela_final");
                VenceuAsTochas();
            }
        }
    }

    private void VenceuAsTochas()
    {
        // ganha o artefato bolado
        this.gameObject.SetActive(false);
    }

    public void Restart()
    {
        image[0].SetActive(true);
        image[1].SetActive(false);
        image[2].SetActive(false);
        image[3].SetActive(true);
    }

}
