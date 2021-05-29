using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private Rigidbody2D rb;

    [SerializeField]
    private float speed = 5f;
    [SerializeField]
    public float runSpeed = 6f;
    private float actualSpeed;

    private Vector3 input;

    private bool isFacingRight = true;
    private bool canRun = false;

    private Animator anim;

    private AudioSource footstep;//Rezende

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        actualSpeed = speed;
        footstep = GetComponent<AudioSource>();//Rezende

        if (this.gameObject.CompareTag("Player"))
        {
            canRun = true;
        }

    }

    void Update()
    {
        input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0);

        if (canRun && Input.GetKey(KeyCode.LeftShift) && input.x != 0)
        {
            actualSpeed = runSpeed;
            anim.SetBool("isRunning", true);
                
        } else
        {
            actualSpeed = speed;
            anim.SetBool("isRunning", false);
        }
 
    }

    private void FixedUpdate()
    {
        transform.position += input * actualSpeed * Time.fixedDeltaTime;
       

        anim.SetInteger("xInput", Mathf.Abs((int)input.x));

        if (input.x < 0 && isFacingRight)
        {
            Flip();
        }
        if (input.x > 0 && !isFacingRight)
        {
            Flip();
        }

    }

    private void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;

    }

    private void Footstep()//Rezende
    {
        footstep.Play();
    }

}