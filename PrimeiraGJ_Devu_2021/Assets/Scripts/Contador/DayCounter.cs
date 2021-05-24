using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayCounter : MonoBehaviour
{
    public static int contadorDeDias = 1;

    public Text textDia;
    
    public void PassouDeDia()
    {
        contadorDeDias++;
        AtualizarDia();
    }

    public void AtualizarDia()
    {
        textDia.text = string.Format("Dia: {0}", contadorDeDias);
    }

}
