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
        while (true)
        {
            yield return new WaitForSeconds(1);
            text.text = $"{counter}";
            counter++;
        }
    }
}
