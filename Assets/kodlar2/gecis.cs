using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System;
using UnityEngine.UI;

public class gecis : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("bolum1son");
        }
    }
    void OnTriggerEnter(Collider nesne)
    {
        if (nesne.tag == "gecis")
        {
            SceneManager.LoadScene(4);
            GM.coinTotal = 0;
        }
        if (nesne.tag == "gecis1")
        {
            SceneManager.LoadScene(5);
            GM.coinTotal = 0;
        }
        if (nesne.tag == "Kapi")
        {

           
           





        }
    }
}
