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
    [SerializeField]
    private float custoStamina = 2f;

    private Vector3 input;

    private bool isFacingRight = true;

    private Animator anim;

    private StaminaBar staminaBar;


    void Start()
    {
        staminaBar = GetComponent<StaminaBar>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        actualSpeed = speed;
    }

    void Update()
    {
        input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0);

        if (Input.GetKey(KeyCode.LeftShift) && input.x != 0)
        {
            actualSpeed = runSpeed;
            staminaBar.UseStamina(custoStamina);        
        }
 
    }

    private void FixedUpdate()
    {
        transform.position += input * actualSpeed * Time.fixedDeltaTime;
        actualSpeed = speed;

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

}
