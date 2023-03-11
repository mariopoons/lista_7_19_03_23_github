using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise4 : MonoBehaviour
{
    public float delayTime = 2.0f; // el tiempo de espera entre cada movimiento
    public float movementDistance = 3.0f; // la distancia que se moverá el objeto en cada iteración
    
    private void Start()
    {
        StartCoroutine(MoveObject());
    }
    public IEnumerator MoveObject()
    {
        for (int i = 0; i < 5; i++)
        {
            Vector3 newPosition = transform.position + Vector3.right * movementDistance; // la posicion donde se encontrara el objeto despues de 2 segundos
            yield return new WaitForSeconds(delayTime); // espera 2 segundos antes de mover el objeto
            transform.position = newPosition; // actualiza la posición del objeto
        }
    }
}

