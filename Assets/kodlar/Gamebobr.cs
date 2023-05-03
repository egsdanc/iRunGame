using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Gamebobr : MonoBehaviour
{
    public float yukseklik;
    int sayac = 0;
    private void OnCollisionEnter(Collision collision)

    {
        if (collision.gameObject.tag == "engel")
        {
            SceneManager.LoadScene("oyunsonu");
        }
        if (collision.gameObject.tag == "capsule")
        {
            SceneManager.LoadScene("oyunsonu");

        }



    }
    private void Update()
    {
        if (transform.position.y <= yukseklik)
        {
            SceneManager.LoadScene("oyunsonu");

        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("oyunsonu");
            GM.coinTotal = 0;
        }



    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coins")
        {
            other.gameObject.SetActive(false);
            GM.coinTotal++;
            Debug.Log(sayac);
        }


    }
}
