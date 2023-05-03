using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if(gameObject.name == "coins")
        {
            GetComponent<TextMesh>().text = "Kazanılan Altın : " + GM.coinTotal;
        }
        if (gameObject.name == "timetxt")
        {
            GetComponent<TextMesh>().text = "Tamamlanan Zaman : " + GM.timeTotal;
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("level4");
        }
        if(Input.GetKeyDown(KeyCode.LeftControl))
            {
            SceneManager.LoadScene("oyunsonu");
        }
        
    }
}
