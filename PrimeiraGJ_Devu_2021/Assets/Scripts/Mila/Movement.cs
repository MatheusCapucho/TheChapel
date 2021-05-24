using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private Rigidbody2D rb;

    [SerializeField]
    private float speed = 5f;
    private Vector3 input;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0);
 
    }

    private void FixedUpdate()
    {
        transform.position += input * speed * Time.fixedDeltaTime;
    }

}
