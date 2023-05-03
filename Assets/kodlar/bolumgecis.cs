using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bolumgecis : MonoBehaviour
{
    public void AnaMenuDon()
    {
        SceneManager.LoadScene("anamenu");
    }
    public void YenidenOyun()
    {
        SceneManager.LoadScene("bolum2");
    }
    public void Bolum3Gecis()
    {
        SceneManager.LoadScene("level4");
    }
}
