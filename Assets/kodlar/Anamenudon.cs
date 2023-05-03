using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Anamenudon : MonoBehaviour
{
    public string anamenu;
    public string bolum2;
    public void Anamenuyedon(){
        SceneManager.LoadScene(anamenu);

    }
    public void bolum2gec(){
        SceneManager.LoadScene(bolum2);
    }
}
