using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DobleClick : MonoBehaviour
{
    public LifeBar Barra;
    public PersonControlller Principal;
    public GameObject nodFather;
    public TextMeshProUGUI potas;
    private int num;
    private float timep;
    // Start is called before the first frame update
    void Start()
    {
       
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void aumenta()
    {
        
        //Debug.Log("Un clik tiemp:"+Time.time+" original:"+timep+" numero:"+num);
        if (timep == 0 )
        {
            timep = Time.time;
            num++;
            //Debug.Log( "num:"+num +"temp:"+timep);
        }
        else
        {
            int temporal = ((Time.time - timep) < .5)?1:0;
            
            if (temporal == 1) {
                if (potas.GetComponent<Items>().numeroItems >= 1)
                {
                    Debug.Log(Principal.vida);
                    if (Principal.vida <= 80)
                        Principal.vida += 20;
                    else
                        Principal.vida = 100;

                    potas.GetComponent<Items>().numeroItems--;
                    potas.text ="x"+ potas.GetComponent<Items>().numeroItems;
                    Barra.life=2 * (Principal.vida / 100);
                    Debug.Log(Principal.vida);
                    Debug.Log(Barra.life);

                }
                //Destroy(nodFather);
                //Instantiate(this.gameObject);
                //print("funciona");

            }
            
            timep = 0;
            num = 0;
            
        }
        

    }
}
