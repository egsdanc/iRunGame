using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class öldür : MonoBehaviour
{
    public GameObject avatara;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            avatara.SetActive(false);
            avatara.transform.position = new Vector3(5f, 0f, -9f);
            avatara.SetActive(true);
        }
    }
}
