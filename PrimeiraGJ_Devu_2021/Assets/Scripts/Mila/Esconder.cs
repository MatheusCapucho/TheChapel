using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esconder : MonoBehaviour
{

    private bool canHide;

    private GameObject player;
    private Animator bushAnim;

    void Start()
    {
        canHide = false;
        player = this.gameObject;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && canHide)
        {
            Hide();
        }
        if (Input.GetKeyDown(KeyCode.S) && canHide)
        {
            HideExit();
        }
    }

    private void Hide()
    {
        player.SetActive(false);
        bushAnim.SetBool("Hide", true);
    }

    private void HideExit()
    {
        bushAnim.SetBool("Hide", false);
        player.SetActive(true);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("HideSpot")) {
            canHide = true;
            bushAnim = collision.GetComponent<Animator>();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("HideSpot")) {
            canHide = false;
            bushAnim = null;
        }
    }

}
