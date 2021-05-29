using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PicSlider : GameFlow
{

    public int pos;
    public static int empty = 9;

    private Vector3 goPos;
    private float movement = 1;

    private void Start()
    {
        goPos = this.gameObject.transform.position; // fazer: 
    }

    public void NaoConseguiFazerUmFimProPuzzle()
    {
        StartCoroutine(Migue());
    }

    public void MovePic()
    {
       switch(pos)
       {
            case 1:
                if(empty == 4)
                {
                    transform.position += new Vector3(0, -movement, 0);
                    pos = 4;
                    empty = 1;
                    break;
                }
                else if (empty == 2)
                {
                    transform.position += new Vector3(movement, 0, 0);
                    pos = 2;
                    empty = 1;
                    break;
                }
                break;

            case 2:
                if (empty == 1)
                {
                    transform.position += new Vector3(-movement, 0, 0);
                    pos = 1;
                    empty = 2;
                    break;
                }
                else if(empty == 3)
                {
                    transform.position += new Vector3(movement, 0, 0);
                    pos = 3;
                    empty = 2;
                    break;
                }
                else if(empty == 5)
                {
                    transform.position += new Vector3(0, -movement, 0);
                    pos = 5;
                    empty = 2;
                    break;
                }
                break;
            case 3:
                if (empty == 2)
                {
                    transform.position += new Vector3(-movement, 0, 0);
                    pos = 2;
                    empty = 3;
                    break;
                }
                else if(empty == 6)
                {
                    transform.position += new Vector3(0, -movement, 0);
                    pos = 6;
                    empty = 3;
                    break;
                }               
                break;
            case 4:
                if (empty == 1)
                {
                    transform.position += new Vector3(0, movement, 0);
                    pos = 1;
                    empty = 4;
                    break;
                }
                else if(empty == 5)
                {
                    transform.position += new Vector3(movement, 0, 0);
                    pos = 5;
                    empty = 4;
                    break;
                }
                else if(empty == 7)
                {
                    transform.position += new Vector3(0, -movement, 0);
                    pos = 7;
                    empty = 4;
                    break;
                }
                break;
            case 5:
                if (empty == 2)
                {
                    transform.position += new Vector3(0, movement, 0);
                    pos = 2;
                    empty = 5;
                    break;
                }
                else if(empty == 4)
                {
                    transform.position += new Vector3(-movement, 0, 0);
                    pos = 4;
                    empty = 5;
                    break;
                }
                else if(empty == 6)
                {
                    transform.position += new Vector3(movement, 0, 0);
                    pos = 6;
                    empty = 5;
                    break;
                }
                else if(empty == 8)
                {
                    transform.position += new Vector3(0, -movement, 0);
                    pos = 8;
                    empty = 5;
                    break;
                }
                break;
            case 6:
                if (empty == 5)
                {
                    transform.position += new Vector3(-movement, 0, 0);
                    pos = 5;
                    empty = 6;
                    break;
                }
                else if(empty == 3)
                {
                    transform.position += new Vector3(0, movement, 0);
                    pos = 3;
                    empty = 6;
                    break;
                }
                else if(empty == 9)
                {
                    transform.position += new Vector3(0, -movement, 0);
                    pos = 9;
                    empty = 6;
                    break;
                }
                break;
            case 7:
                if (empty == 4)
                {
                    transform.position += new Vector3(0, movement, 0);
                    pos = 4;
                    empty = 7;
                    break;
                }
                else if(empty == 8)
                {
                    transform.position += new Vector3(movement, 0, 0);
                    pos = 8;
                    empty = 7;
                    break;
                }       
                break;
            case 8:
                if (empty == 7)
                {
                    transform.position += new Vector3(-movement, 0, 0);
                    pos = 7;
                    empty = 8;
                    break;
                }
                else if(empty == 5)
                {
                    transform.position += new Vector3(0, movement, 0);
                    pos = 5;
                    empty = 8;
                    break;
                }
                else if(empty == 9)
                {
                    transform.position += new Vector3(movement, 0, 0);
                    pos = 9;
                    empty = 8;
                    break;
                }
                break;
            case 9:
                if (empty == 6)
                {
                    transform.position += new Vector3(0, movement, 0);
                    pos = 6;
                    empty = 9;
                    break;
                }
                else if(empty == 8)
                {
                    transform.position += new Vector3(-movement, 0, 0);
                    pos = 8;
                    empty = 9;
                    break;
                }
                break;
        }
    }

    IEnumerator Migue()
    {

        yield return new WaitForSeconds(30f);
        olhoVermelho = true;
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Capela_final");
    }

}
