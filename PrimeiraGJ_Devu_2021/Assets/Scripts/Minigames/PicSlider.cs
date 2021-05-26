using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PicSlider : MonoBehaviour
{

    public int pos;
    public static int empty;

    private Vector3 goPos;
    [SerializeField]
    private float movement;



    private void Start()
    {
        goPos = this.gameObject.transform.position;
    }

    public void MovePic(int buttonNumber)
    {
       switch(pos)
       {
            case 1:
                if(empty == 4)
                {
                    goPos = new Vector3(goPos.x, goPos.y + movement, goPos.z);
                }
                if (empty == 2)
                {
                    goPos = new Vector3(goPos.x + movement, goPos.y, goPos.z);
                }
                break;
            case 2:
                if (empty == 1)
                {
                    goPos = new Vector3(goPos.x - movement, goPos.y, goPos.z);
                }
                if (empty == 3)
                {
                    goPos = new Vector3(goPos.x + movement, goPos.y, goPos.z);
                }
                if (empty == 5)
                {
                    goPos = new Vector3(goPos.x , goPos.y - movement, goPos.z);
                }
                break;
        }
    }

}
