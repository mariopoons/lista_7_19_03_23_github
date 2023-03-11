using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class exercise3 : MonoBehaviour

{
    public TextMeshProUGUI valueText; // referencia al componente TextMeshProUGUI donde se mostrar� el valor
    private int value = 0; // inicializa el valor en 0

    // este m�todo se ejecutar� cada vez que se presione el bot�n "up"
    public void IncreaseValue()
    {
        value += 1; // agrega 1 al valor actual
        UpdateValueText(); // actualiza el valor en el objeto TextMeshProUGUI
    }

    // este m�todo se ejecutar� cada vez que se presione el bot�n "down"
    public void DecreaseValue()
    {
        value -= 1; // resta 1 al valor actual
        UpdateValueText(); // actualiza el valor en el objeto TextMeshProUGUI
    }

    // este m�todo actualizar� el valor en el objeto TextMeshProUGUI
    private void UpdateValueText()
    {
        valueText.text = "Value: " + value.ToString(); // actualiza el texto en el objeto TextMeshProUGUI
    }
}

    
