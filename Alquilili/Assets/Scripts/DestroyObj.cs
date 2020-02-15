using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DestroyObj : MonoBehaviour
{
    public TextMeshProUGUI numpotas;
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
            numpotas.GetComponent<Items>().numeroItems+=1;
            numpotas.text = "x"+numpotas.GetComponent<Items>().numeroItems;

            Destroy(this.gameObject);
        }
    }
}
