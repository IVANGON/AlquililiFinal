using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activador : MonoBehaviour
{
    public GameObject dialog;
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
        if (other.tag == "Player")
        {
            dialog.SetActive(true);
        }
    }
}
