using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed = 5.0f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("left"))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0); 
        }
        if (Input.GetKeyDown("right"))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKeyDown("up"))
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
        if (Input.GetKeyDown("down"))
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }
    }

    void OnCollisionEnter (Collision collision)
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
}
