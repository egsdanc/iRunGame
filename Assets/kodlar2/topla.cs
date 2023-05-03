using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class topla : MonoBehaviour
{
    public Text sayacText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        sayacText.text = "Skor = 24/" + GM.coinTotal;
    }
}