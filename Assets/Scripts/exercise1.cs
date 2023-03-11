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
        for (int i = 0; i < 10; i++) // bucle donde apareceran 10 cubos a la vez en posiciones diferentes 
        {
            xRandomPos = Random.Range(-5, 7); // posicion aleatoria enntre -5 y 7
            yRandomPos = Random.Range(-7, 5); // posicion aleatoria enntre 7 y 5
            zRandomPos = Random.Range(-6, 6); // posicion aleatoria enntre -6 y 6

            Vector3 pos = new Vector3(xRandomPos, yRandomPos, zRandomPos); // el numero elegido entre las opciones anteriores 

            // esto hará que también tengan escalas diferentes
            Instantiate(cubo, pos, Quaternion.identity);
            GameObject go = Instantiate(cubo, pos, Quaternion.identity);
            go.transform.localScale = Vector3.one * Random.Range(1,4);
        }
    }
}
