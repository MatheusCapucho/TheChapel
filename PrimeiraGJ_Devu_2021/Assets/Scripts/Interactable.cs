using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public bool isInRange;
    public KeyCode botao; 
    public UnityEvent[] actions;

    void Update()
    {
        if (isInRange)
        {
            if (Input.GetKeyDown(botao))
            {
               
                for (int i = 0; i < actions.Length; i++)

                { 
                    actions[i].Invoke();
                }         
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
        }
    }
}
