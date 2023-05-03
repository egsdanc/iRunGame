using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bölüm2YButon : MonoBehaviour
{
    public string anamenu;
    public string bolum2;


    public void anamenu2()
    {
        SceneManager.LoadScene(anamenu);
    }
    public void bolum2yeniden()
    {
        SceneManager.LoadScene(bolum2);
    }

}
