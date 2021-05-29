using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextInput : GameFlow
{
    private string resposta = "Obsessão";
    private string resposta2 = "obsessão";
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
           
            StartCoroutine(MudarCena());
        }
        else
        {
            Debug.Log("Vc errou, seu merda!!");
        }
    }


    private IEnumerator MudarCena()
    {
        yield return new WaitForSeconds(1f);

        

        SceneManager.LoadScene("Capela_final");   

    }


}
