using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float speed = 3.5f;
    private SpriteRenderer sr; 

    void FixedUpdate()
    {
        transform.position += new Vector3(1, 0, 0) * speed * Time.fixedDeltaTime;
        sr = this.gameObject.GetComponent<SpriteRenderer>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Wall"))
        {
            sr.flipX = !sr.flipX;
            speed *= -1;
        }
    }

}
