using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilPlatformContoller : MonoBehaviour
{
    public float moveSpeed = 2.0f; // Platformun a�a�� hareket h�z�
    public float downDistance = 1.0f; // A�a�� inmesi gereken mesafe
    private Vector3 initialPosition; // Ba�lang�� pozisyonu
    private Vector3 targetPosition; // Hedef pozisyon
    private bool isMoving = false; // Platformun hareket etti�ini belirlemek i�in kullan�l�r
    public Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
        // Ba�lang�� pozisyonunu kaydedin
        initialPosition = transform.position;
        // Hedef pozisyonu hesaplay�n
        targetPosition = initialPosition - Vector3.up * downDistance;
    }
    private void FixedUpdate()
    {
        if (isMoving)
        {
            Debug.Log("safsadad");
            transform.position = Vector3.Lerp(transform.position, targetPosition, moveSpeed );
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, startPosition, moveSpeed );
        }
    }
    private void Update()
    {
        // Platformu a�a�� hareket ettirin
        
    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isMoving = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        isMoving = false;
    }
  

}
