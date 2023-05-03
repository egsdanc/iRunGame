using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class baslangic : MonoBehaviour
{
    public string bolum1;
    public void sahnedegisim ()
    {
        Application.LoadLevel(bolum1);
    }
    public void OyundanCik()
    {
        Application.Quit();
    }
}
