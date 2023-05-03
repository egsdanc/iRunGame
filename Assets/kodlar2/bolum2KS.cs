using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bolum2KS : MonoBehaviour
{
    public string anamenu;
    public string bolum2KSss;
    public void Anamenuye()
    {
        SceneManager.LoadScene(anamenu);

    }
    public void bolum2Kgec()
    {
        SceneManager.LoadScene(bolum2KSss);
    }
}
