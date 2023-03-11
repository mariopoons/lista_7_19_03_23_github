using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class exercise3 : MonoBehaviour

{
    private int value = 0;
    public TextMeshProUGUI valueText;


    // esta funcion actualizará el valor que haya en pantalla
    private void UpdateValueText()
    {
        valueText.text = "Value: " + value.ToString();
    }

    // esta funcion sumará 1 cada vez que presiones el botón "up"
    public void IncreaseValue()
    {
        value += 1; // suma 1 al valor actual
        UpdateValueText(); // actualiza el valor del número que haya
    }

    // esta funcion restará 1 cada vez que presiones el botón "down"
    public void DecreaseValue()
    {
        value -= 1; // resta 1 al valor actual
        UpdateValueText(); // actualiza el valor del número que haya
    }

}

    
