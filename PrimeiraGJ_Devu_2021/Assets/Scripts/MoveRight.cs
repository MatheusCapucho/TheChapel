using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;
    public float speed = 5f;
    void Start()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider2D>().size.x;
    }


    void Update()
    {
        transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;

        if (transform.position.x > startPos.x + repeatWidth)
        {
            transform.position = startPos;
        }
    }
}
