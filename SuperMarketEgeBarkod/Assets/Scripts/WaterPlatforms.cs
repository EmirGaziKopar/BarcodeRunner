using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPlatforms : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public bool constraintsOff;
    public float timer;
    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Patato")
        {
            Debug.Log("Patato Geldi");
            constraintsOff = true;
            
        }
    }

    private void Update()
    {
        if (constraintsOff)
        {
            
            if(timer < 0.2f)
            {
                timer += Time.deltaTime;
            }
            else
            {
                rigidbody2D.constraints = RigidbodyConstraints2D.None;
            }
        }
    }
}
