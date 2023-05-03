using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuYonetimi1 : MonoBehaviour
{
    public string bolum1;
    public string bolum2;
    public string level4;



    public void sahnegecisoyun()
    {
        SceneManager.LoadScene(bolum1);
    }
    public void sahnegecis()
    {
        SceneManager.LoadScene(bolum2);
    }
    public void sahnegecis1()
    {
        SceneManager.LoadScene(level4);
    }

}

