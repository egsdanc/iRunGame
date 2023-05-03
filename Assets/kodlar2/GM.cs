using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{ 
    public static int coinTotal = 0;
    public static float timeTotal = 0;

    
    void Start()
    {
        
    }

    void Update()
    {
        timeTotal += Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(7);
        }
    }

}
