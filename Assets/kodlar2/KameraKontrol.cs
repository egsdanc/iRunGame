using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraKontrol : MonoBehaviour
{
    public GameObject top;
    Vector3 aradakiMesafe;
    void Start()
    {
        aradakiMesafe = transform.position - top.transform.position;
    }

   
    void LateUpdate()
        //bütün update bitince çalışıyor, kamera daha iyi görüntü veriyor.
    {
        transform.position = transform.position + aradakiMesafe;
    }
}
