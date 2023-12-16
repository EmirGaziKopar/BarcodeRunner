using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatatoController : MonoBehaviour
{
    public List<GameObject> Joints;

    public bool isD;
    public bool isA;
    public bool isSpace;
    int counter;
    Rigidbody2D rigidbody2D;
    public float speed;
    public float horizontalSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }


    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A)) //GetKey yapýp öyle true yap counter koy sadece 1 kez çalýþsýn else ise counter tekrar 0 olsun
        {
            for (int i = 0; i < Joints.Count; i++)
            {               
                if (Joints[i].GetComponent<Rigidbody2D>() != null)
                {
                    Joints[i].GetComponent<Rigidbody2D>().velocity = new Vector3(-horizontalSpeed * Time.deltaTime, Joints[i].GetComponent<Rigidbody2D>().velocity.y, 0);
                }

            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            for (int i = 0; i < Joints.Count; i++)
            {
                if (Joints[i].GetComponent<Rigidbody2D>() != null)
                {
                    Joints[i].GetComponent<Rigidbody2D>().velocity = new Vector3(horizontalSpeed * Time.deltaTime, Joints[i].GetComponent<Rigidbody2D>().velocity.y, 0);
                }

            }
        }
        if (Input.GetKey(KeyCode.Space))
        {
            
            if (counter < 1)
            {
                counter++;
                for (int i = 0; i < Joints.Count; i++)
                {
                    Joints[i].GetComponent<Rigidbody2D>().velocity = new Vector3(0, speed * Time.deltaTime, 0);
                }
            }
            
        }
        else
        {
            counter = 0;
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) //GetKey yapýp öyle true yap counter koy sadece 1 kez çalýþsýn
        {
            isA = true;
        }
        else
        {
            isA = false;
        }
        
        if (Input.GetKeyDown(KeyCode.D))
        {
            isD = true;
            
            //rigidbody2D.velocity = new Vector2(horizontalSpeed * Time.deltaTime, 0);
        }
        else
        {
            isD = false;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isSpace = true;
            
        }
        else
        {
            isSpace = false;
        }
    }

}

