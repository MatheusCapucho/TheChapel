using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndarPraIgreja : MonoBehaviour
{

    private float speed = 3f;
    private bool canGo = false;
    private Animator anim;

    private void Start()
    {
        anim = this.gameObject.GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        if (canGo)
        {
            this.gameObject.transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
        }
    }
    public void GoIgreja()
    {
        canGo = true;
        anim.SetTrigger("Move");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Igreja"))
        {
            Destroy(this.gameObject);
        }
    }



}
