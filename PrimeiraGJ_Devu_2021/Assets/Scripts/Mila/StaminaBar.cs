using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class StaminaBar : MonoBehaviour
{

    public Slider slider;

    public float maxStamina;
    private float currentStamina;

    private Coroutine regen;

    public Vector3 offset = new Vector3(0,0,0);

    void Start()
    {
        currentStamina = maxStamina;
        slider.maxValue = maxStamina;
        slider.value = maxStamina;

    }

    private void Update()
    {
        slider.transform.position = Camera.main.WorldToScreenPoint(transform.position + offset);
    }

    public void UseStamina(float amount)
    {
        slider.gameObject.SetActive(true);
        if (currentStamina - amount >= 0)
        {
            currentStamina -= amount;
            slider.value = currentStamina;

            if (regen != null)
                StopCoroutine(regen);

            regen = StartCoroutine(RegenStamina());
        }
    }

   private IEnumerator RegenStamina()
    {
        yield return new WaitForSeconds(1);

        while(currentStamina < maxStamina)
        {
            currentStamina += maxStamina / 50;
            slider.value = currentStamina;
            yield return new WaitForSeconds(.1f);
        }
        slider.gameObject.SetActive(false);
    }

}
