using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using static UnityEditor.PlayerSettings;
//https://madnesslabo.net/utage/?page_id=11109
//https://xr-hub.com/archives/14069
//https://gametukurikata.com/program/data
//https://joytas.net/programming/unity/unity%e3%81%a7%e3%82%b7%e3%83%bc%e3%83%b3%e3%82%92%e3%81%be%e3%81%9f%e3%81%84%e3%81%a7%e5%80%a4%e3%82%92%e4%bf%9d%e6%8c%81%e3%81%99%e3%82%8b
//https://rakko.tools/tools/86/
//https://3dunity.org/game-create-lesson/2d-action-game/
public class player : MonoBehaviour
{
    public static player instance;
    public float speed;
    public float runspeed;
    private bool isJumping = false;
    public int Playerlife;
    int sceneflag = 0;
    Rigidbody2D rbody;

    private int jumpflag = 0;
    public SpriteRenderer sp;

    // ダメージ判定フラグ
    private bool isDamage { get; set; }
    // Start is called before the first frame update
    void Start()
    {
        Playerlife = 5;
    }



    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += speed;

        }
        if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.Y))
        {
            pos.x += runspeed;

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= speed;

        }
        if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.Y))
        {
            pos.x -= runspeed;

        }
        
        if (isDamage)
        {

            float level = Mathf.Abs(Mathf.Sin(Time.time * 10));
            sp.color = new Color(1f, 1f, 1f, level);

        }


        transform.position = new Vector2(pos.x, pos.y);

    }
    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.CompareTag("Enemy"))
        {
            Playerlife = Playerlife - 1;
            if (Playerlife <= 0)
            {
                Destroy(this.gameObject);
            }
        if (isDamage)
        {
            return;
        }
        StartCoroutine(OnDamage());
        }
    }

    public IEnumerator OnDamage()
    {

        yield return new WaitForSeconds(10.0f);

        // 通常状態に戻す
        isDamage = false;
        sp.color = new Color(1f, 1f, 1f, 1f);

    }
}
