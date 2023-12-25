using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GOAL : MonoBehaviour
{
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
        if (col.gameObject.tag == "GOAL")
        {
            SceneManager.LoadScene("stage2future");//ゴールに触れたら最初からスタート
        }
        if (col.gameObject.tag == "stage2Gole")
        {
            SceneManager.LoadScene("Boss");//穴に落ちたら最初からスタート
        }
    }
}
