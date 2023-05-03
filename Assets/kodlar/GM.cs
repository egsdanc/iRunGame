using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM1 : MonoBehaviour
{ 
    public static int coinTotal = 0;
    public static float timeTotal = 0;

    
    void Start()
    {
        
    }

    void Update()
    {
        timeTotal += Time.deltaTime;
    }
}
