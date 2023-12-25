using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyManagement : MonoBehaviour
{
    private float SPEED = 0.01f;
    private int  count = 0;
    private int enemyHP;
    public float speed;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        enemyHP = 10;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        count += 1;
        if (count < 500) { 

            position.x += SPEED;
        }
        else if(count>500)
        {
            position.x -= SPEED;
        }
        if(count==1000)
        {
            count =0;
        }
     
        transform.position = position;
    }
    
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "player")
        {
          //çUåÇèàóù
        }
        if (col.gameObject.CompareTag("Bullet"))
        {
            enemyHP = enemyHP - 1;
            if (enemyHP <= 0)
            {
                Destroy(this.gameObject);
            }
        }
        
    }
}
