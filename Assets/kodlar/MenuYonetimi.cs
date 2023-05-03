using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuYonetimi : MonoBehaviour
{
    public string bolumler;
    
    public void sahnegecisoyun()
    {
        SceneManager.LoadScene(bolumler);
    }
    public void oyundancik()
    {
        Application.Quit();
    }
}

