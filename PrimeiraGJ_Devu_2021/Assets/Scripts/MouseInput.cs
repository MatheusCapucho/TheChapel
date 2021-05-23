using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInput : MonoBehaviour
{
    public Camera cam;
    public Transform mouseGO;
    public Vector2 mouse;
    
    void Update()
    {
        mouse = cam.ScreenToWorldPoint(Input.mousePosition);
        mouseGO.position = mouse;       
    }
}
