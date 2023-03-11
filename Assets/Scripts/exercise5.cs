using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class exercise5 : MonoBehaviour
{
    
    public float movementSpeed = 5.0f; // velocidad de movimiento de la esfera
    public float disappearTime = 2.0f; // tiempo que tarda la esfera en desaparecer
    public float appearTime = 2.0f; // tiempo que tarda la esfera en aparecer de nuevo
    public int maxMisses = 3; // número máximo de veces que se puede perder
    public TextMeshProUGUI pointsText; // referencia al componente TextMeshProUGUI que muestra los puntos
    public TextMeshProUGUI livesText; // referencia al componente TextMeshProUGUI que muestra las vidas
    public AudioClip defeatSound; // sonido que se reproduce cuando se pierde
    public AudioClip successSound; // sonido que se reproduce cuando se gana

    private int points = 0; // número de puntos obtenidos
    private int misses = 0; // número de intentos fallidos
    private bool canHit = true; // indica si se puede golpear la esfera
    private AudioSource audioSource; // referencia al componente AudioSource

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(MoveSphere());
        UpdatePointsText();
        UpdateLivesText();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (canHit && collision.gameObject.CompareTag("Player"))
        {
            points += 1;
            canHit = false;
            audioSource.PlayOneShot(successSound);
            GetComponent<MeshRenderer>().material.color = Color.green;
            UpdatePointsText();
        }
    }

    IEnumerator MoveSphere()
    {
        while (true)
        {
            yield return new WaitForSeconds(appearTime);
            canHit = true;
            GetComponent<MeshRenderer>().material.color = Color.blue;
            transform.position = new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(1.0f, 5.0f), Random.Range(-5.0f, 5.0f));
            yield return new WaitForSeconds(disappearTime);
            if (canHit)
            {
                misses += 1;
                audioSource.PlayOneShot(defeatSound);
                UpdateLivesText();
                if (misses >= maxMisses)
                {
                    GameOver();
                    break;
                }
            }
        }
    }

    void UpdatePointsText()
    {
        pointsText.text = "Points: " + points.ToString();
    }

    void UpdateLivesText()
    {
        livesText.text = "Lives: " + (maxMisses - misses).ToString();
    }

    void GameOver()
    {
        Debug.Log("Game Over!");
        // aquí puedes agregar cualquier lógica adicional para mostrar un mensaje de "Game Over" o para reiniciar el juego
    }
}

