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
            SceneManager.LoadScene("stage2future");//�S�[���ɐG�ꂽ��ŏ�����X�^�[�g
        }
        if (col.gameObject.tag == "stage2Gole")
        {
            SceneManager.LoadScene("Boss");//���ɗ�������ŏ�����X�^�[�g
        }
    }
}
