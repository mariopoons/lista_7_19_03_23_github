using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise1 : MonoBehaviour
{
    public GameObject cubo;
    
    public int xRandomPos;
    public int yRandomPos;
    public int zRandomPos;

    private void Start()
    {
        for (int i = 0; i < 10; i++) 
        {
            xRandomPos = Random.Range(-5, 7);
            yRandomPos = Random.Range(-7, 5);
            zRandomPos = Random.Range(-6, 6);

            Vector3 pos = new Vector3(xRandomPos, yRandomPos, zRandomPos);

            

            Instantiate(cubo, pos, Quaternion.identity);
            GameObject go = Instantiate(cubo, pos, Quaternion.identity);
            go.transform.localScale = Vector3.one * Random.Range(1,4);
        }
    }
}
