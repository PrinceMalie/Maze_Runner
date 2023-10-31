using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class Player : MonoBehaviour
{
    float speed = 100.0f;
    int key_count = 0;

    public Text myText; 

    Rigidbody RB;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if(Input.GetKey("left"))
        {
            pos.x -= speed * Time.deltaTime;

        }
        if (Input.GetKey("right"))
        {
            pos.x += speed * Time.deltaTime;

        }
        if (Input.GetKey("up"))
        {
            pos.y += speed * Time.deltaTime;

        }
        if (Input.GetKey("down"))
        {
            pos.y -= speed * Time.deltaTime;

        }

       // transform.position = pos;
        RB.MovePosition(pos);
    }

    void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.tag == "keys")
        {
            Destroy(collision.gameObject);

            key_count++;
        }

        if(collision.gameObject.tag == "door" && key_count == 3)
        {
            Destroy(collision.gameObject);
            Application.Quit();
        }
    }
}
