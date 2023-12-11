using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatatoController : MonoBehaviour
{
    public List<GameObject> Joints;

    Rigidbody2D rigidbody2D;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }


    private void FixedUpdate()
    {
        //transform.position += new Vector3(0, 0.01f, 0);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i<Joints.Count; i++)
            {
                Joints[i].GetComponent<Rigidbody2D>().velocity = new Vector3(0, speed * Time.deltaTime, 0);
            }
        }
    }
}
