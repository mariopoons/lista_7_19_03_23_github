using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class exercise3 : MonoBehaviour

{
    public TextMeshProUGUI valueText; // referencia al componente TextMeshProUGUI donde se mostrará el valor
    private int value = 0; // inicializa el valor en 0

    // este método se ejecutará cada vez que se presione el botón "up"
    public void IncreaseValue()
    {
        value += 1; // agrega 1 al valor actual
        UpdateValueText(); // actualiza el valor en el objeto TextMeshProUGUI
    }

    // este método se ejecutará cada vez que se presione el botón "down"
    public void DecreaseValue()
    {
        value -= 1; // resta 1 al valor actual
        UpdateValueText(); // actualiza el valor en el objeto TextMeshProUGUI
    }

    // este método actualizará el valor en el objeto TextMeshProUGUI
    private void UpdateValueText()
    {
        valueText.text = "Value: " + value.ToString(); // actualiza el texto en el objeto TextMeshProUGUI
    }
}

    
