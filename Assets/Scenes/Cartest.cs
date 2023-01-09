using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cartest : MonoBehaviour
{
     float speed = 5.0f;
    
    void Start()
    {
        speed = 10.0f;
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        { 
            transform.Translate(-1 * Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A)) { 
            transform.Rotate(0, -3, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 3, 0);
        }

    }

    void oncollisionenter(Collision other)
    {
        if(other.gameObject.tag == "people")
        {
            Destroy(gameObject);
        }
    }
}
