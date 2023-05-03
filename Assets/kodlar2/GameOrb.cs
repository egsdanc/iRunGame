using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOrb : MonoBehaviour
{
    public float yukseklik;
    int sayac = 0;
    public int toplanilacakObjeSayisi;
    public Text sayacText;
    private void OnCollisionEnter(Collision collision)
        

    {

        if (collision.gameObject.tag == "engel")
        {
            SceneManager.LoadScene("bolum2SY");
        }
    
        
        
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("bolum2SY");
        }
       


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Altin")
        {
            other.gameObject.SetActive(false);
            GM.coinTotal=GM.coinTotal+1;
           
        }
        if(GM.coinTotal == 24 && other.gameObject.tag == "Kapi")
        {
            SceneManager.LoadScene("level2win");
            GM.coinTotal = 0;
        }
   
        if (other.gameObject.tag == "emre")
        {
            transform.position = new Vector3(-2801, 275, 245);
        }
        if (other.gameObject.tag == "görev1")
        {
            transform.position = new Vector3(63, 6,-22);
        }
        if (other.gameObject.tag == "görev2")
        {
            transform.position = new Vector3(26, 8, -20);
        }
        if (other.gameObject.tag == "görev3")
        {
            transform.position = new Vector3(25, 18,25);
        }
        if (other.gameObject.tag == "görev4")
        {
            transform.position = new Vector3(116, 6166, -36727);
        }
        if (other.gameObject.tag == "görev5")
        {
            transform.position = new Vector3(-29, 1, 27);
        }











    }
}
