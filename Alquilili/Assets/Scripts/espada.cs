using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class espada : MonoBehaviour
{
    public Animator principal;
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
        Debug.Log(principal.GetCurrentAnimatorStateInfo(0).IsName("Corte2"));
        if (other.tag == "Enemy" && principal.GetCurrentAnimatorStateInfo(0).IsName("Corte2")==true)
        {
            Debug.Log("collisontriger");
            other.GetComponent<Animator>().SetBool("Muerte", true);
            Destroy(other.gameObject, 3f);
            Destroy(other.transform, 3f);
        }
    }
}
