using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{


    Rigidbody2D rb;

    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
              
        Vector2 myGravity = new Vector2(0, 9.81f * 2);

        rb.AddForce(myGravity);

    }
}
