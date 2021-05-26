using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{

    [SerializeField]
    private float tempoMaxDePuzzle = 60f;

    private float tempoAtual;
    private bool isActive;

    public Slider slider; // inspector

    void Start()
    {
        isActive = true;
        tempoAtual = tempoMaxDePuzzle;
        slider.maxValue = tempoMaxDePuzzle;
        slider.value = tempoMaxDePuzzle;
    }

    void Update()
    {
        if (isActive && tempoAtual > 0)
        {
            tempoAtual -= Time.deltaTime;
            slider.value = tempoAtual;
        }

        else
        {
            tempoAtual = 0;
            isActive = false;

            // da o triger no evento.

        }
    }
}
