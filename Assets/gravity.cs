using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class gravity : MonoBehaviour
{
    Rigidbody2D rb;

    int ceilingflag = 0;
    [SerializeField] int graflag;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float gra = 9.81f;

        Vector2 myGravity = new Vector2(0, 9.81f * 2);
        if (ceilingflag == 0)
        {
            if (graflag == 0)
            {
                Physics2D.gravity = new Vector2(0, -gra);
            }
            else if (graflag == 1)
            {
                Physics2D.gravity = new Vector2(0, gra);
            }
            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(myGravity);
                Physics2D.gravity = new Vector2(0, gra);
                graflag = 1;
            }
            if (Input.GetKey(KeyCode.S))
            {
                graflag = 0;
            }
        }

    }
}


