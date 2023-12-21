using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilPlatformContoller : MonoBehaviour
{
    public float moveSpeed = 2.0f; // Platformun aþaðý hareket hýzý
    public float downDistance = 1.0f; // Aþaðý inmesi gereken mesafe
    private Vector3 initialPosition; // Baþlangýç pozisyonu
    private Vector3 targetPosition; // Hedef pozisyon
    private bool isMoving = false; // Platformun hareket ettiðini belirlemek için kullanýlýr
    public Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
        // Baþlangýç pozisyonunu kaydedin
        initialPosition = transform.position;
        // Hedef pozisyonu hesaplayýn
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
        // Platformu aþaðý hareket ettirin
        
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
