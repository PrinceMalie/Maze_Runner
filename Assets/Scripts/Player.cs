using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed = 100.0f;
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

    /*void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.tag == "walls")
        {
            if (Input.GetKeyDown("left"))
            {
                transform.Translate(speed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKeyDown("right"))
            {
                transform.Translate(-speed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKeyDown("up"))
            {
                transform.Translate(0, -speed * Time.deltaTime, 0);
            }
            if (Input.GetKeyDown("down"))
            {
                transform.Translate(0, speed * Time.deltaTime, 0);
            }
        }
    }*/
}
