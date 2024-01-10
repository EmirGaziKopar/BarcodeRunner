using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isGroundedControl : MonoBehaviour
{
    public static bool collidedOnBasket;
    public static bool isGrounded;

    private void Start()
    {
        collidedOnBasket = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
        if(collision.gameObject.tag == "Basket")
        {
            Debug.Log("Çalýþtý");
            collidedOnBasket = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Basket")
        {
            Debug.Log("Çalýþtý");
            collidedOnBasket = false;
        }
    }

}
