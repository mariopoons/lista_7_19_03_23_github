using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class exercise2 : MonoBehaviour
{
    public int counter = 0;
    public TextMeshProUGUI text;

    private void Start()
    {
        StartCoroutine("Timer");
    }
    public IEnumerator Timer()
    {
        while (true) // bucle infinito
        {
            yield return new WaitForSeconds(1); // espera 1 segundos antes de sumar 1 al contador
            text.text = $"{counter}"; // el texto que aparecera en pantalla
            counter++; 
        }
    }
}
