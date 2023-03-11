using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class exercise3 : MonoBehaviour

{
    private int value = 0;
    public TextMeshProUGUI valueText;


    // esta funcion actualizar� el valor que haya en pantalla
    private void UpdateValueText()
    {
        valueText.text = "Value: " + value.ToString();
    }

    // esta funcion sumar� 1 cada vez que presiones el bot�n "up"
    public void IncreaseValue()
    {
        value += 1; // suma 1 al valor actual
        UpdateValueText(); // actualiza el valor del n�mero que haya
    }

    // esta funcion restar� 1 cada vez que presiones el bot�n "down"
    public void DecreaseValue()
    {
        value -= 1; // resta 1 al valor actual
        UpdateValueText(); // actualiza el valor del n�mero que haya
    }

}

    
