using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextInput : GameFlow
{
    private string resposta = "Obcessão";
    private string resposta2 = "obcessão";
    private InputField input;

    public GameObject canvas;


    private void Start()
    {
        input = GetComponent<InputField>();
        input.gameObject.SetActive(false);
    }

    public void ReadInput()
    {
        if (input.text == resposta || input.text == resposta2)
        {
            sceneAfterMinigame++;
            olhoAmarelo = true;
            StartCoroutine(MudarCena(sceneAfterMinigame));
        }
        else
        {
            Debug.Log("Vc errou, seu merda!!");
        }
    }


    private IEnumerator MudarCena(int scene)
    {
        yield return new WaitForSeconds(2f);

        // fadein

        //mila fala alguma besteira

        //yield return new WaitForSeconds(tempo da fala da mina + 1f);

        SceneManager.LoadScene(scene);   

    }


}
