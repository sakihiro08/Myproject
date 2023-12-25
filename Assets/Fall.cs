using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fall : MonoBehaviour
{
    Rigidbody2D rbody;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {

    }
    
  void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Hole")
        {
            SceneManager.LoadScene("stage1");//穴に落ちたら最初からスタート
        }
        if (col.gameObject.tag == "Hole2")
        {
            SceneManager.LoadScene("stage1now");//穴に落ちたら最初からスタート
        }
        if (col.gameObject.tag == "Hole3")
        {
            SceneManager.LoadScene("stage2future");//穴に落ちたら最初からスタート
        }   
    }
}
