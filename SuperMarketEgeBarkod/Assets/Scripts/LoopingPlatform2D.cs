using UnityEngine;

public class LoopingPlatform2D : MonoBehaviour
{
    public float moveDistance = 5.0f; // Hareket edilecek mesafe
    public float moveSpeed = 2.0f; // Hareket h�z�

    private Vector3 initialPosition;
    private float direction = 1.0f; // Hareket y�n� (sa�a ba�la)
    new Rigidbody2D rigidbody2D;
    

    void Start()
    {
        initialPosition = transform.position;
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Hareket y�n�n� g�ncelle
        if (transform.position.x >= initialPosition.x + moveDistance)
        {
            direction = -1.0f; // Hareketi sola �evir
            rigidbody2D.velocity = Vector2.zero;
        }
        else if (transform.position.x <= initialPosition.x)
        {
            direction = 1.0f; // Hareketi tekrar sa�a �evir
            rigidbody2D.velocity = Vector2.zero;
        }

        // Hareketi uygula
        //Vector3 movement = Vector3.right * direction * moveSpeed * Time.deltaTime;
        //transform.Translate(movement);

        rigidbody2D.velocity = new Vector2(direction * moveSpeed,0);
    }

 
}
