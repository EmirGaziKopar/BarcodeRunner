using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderControl : MonoBehaviour
{
    public static bool CollisionDetected;
    public AudioSource audioSource;
    public AudioSource diit;
    public GameObject diitAnim; //GameObjeyi setActive true yapýnca animasyon otomatik olarak baþlayacak

    private void Start()
    {
        CollisionDetected = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Patato")
        {
            diit.Play();
            diitAnim.SetActive(true);
            Debug.Log("Succesful");
            CollisionDetected = true;

            //audioSource.Play();
        }
    }
}
