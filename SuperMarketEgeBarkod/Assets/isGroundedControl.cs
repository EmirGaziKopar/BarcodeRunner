using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isGroundedControl : MonoBehaviour
{

    public static bool isGrounded;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
    }
    
}
