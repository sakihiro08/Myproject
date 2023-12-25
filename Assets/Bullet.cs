using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifetime = 0.25f;
    float time = 0f;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += 0.1f;
        transform.position = new Vector2(pos.x, pos.y);
        time += Time.deltaTime;
        print(time);
        if(time>lifetime)
        {
            Destroy(this.gameObject);
        }
    }
     void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
        }
        if (col.gameObject.tag == "Ground")
        {
            Destroy(this.gameObject);
        }

    }
}
