using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTest : MonoBehaviour
{
    public float moveDistance = 5.0f; // Hareket edilecek mesafe
    public float moveSpeed = 2.0f; // Hareket h�z�

    private Vector3 initialPosition;
    private float direction = 1.0f; // Hareket y�n� (sa�a ba�la)



    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        // Hareket y�n�n� g�ncelle
        if (transform.position.x >= initialPosition.x + moveDistance)
        {
            direction = -1.0f; // Hareketi sola �evir
        }
        else if (transform.position.x <= initialPosition.x)
        {
            direction = 1.0f; // Hareketi tekrar sa�a �evir
        }

        // Hareketi uygula
        Vector3 movement = Vector3.right * direction * moveSpeed * Time.deltaTime;
        transform.Translate(movement);
    }
}
