using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    public GameObject NodoPadre;
    public GameObject Visible;

    // Start is called before the first frame update
    void Start()
    {
       
    }
  

    // Update is called once per frame
    void Update()
    {
    }
    

    public void DragItemp()
    {


        this.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        Debug.Log("primero" + this);
        Debug.Log(this.GetComponent<RectTransform>().offsetMax);
        Debug.Log(this.GetComponent<RectTransform>().position);

    }
    public void DropItem()
    {
        if(this.GetComponent<RectTransform>().offsetMax.x < -10 || this.GetComponent<RectTransform>().offsetMax.y < -10 ||
            this.GetComponent<RectTransform>().offsetMax.x > 20 || this.GetComponent<RectTransform>().offsetMax.y > 20    
            )
        {
            Destroy(NodoPadre.gameObject);
            
        }

        this.transform.localPosition= Vector3.zero;
        //Debug.Log("segundo");
        //Debug.Log(this.GetComponent<RectTransform>().parent);
        //Debug.Log(this.GetComponent<RectTransform>().rect);
        //Debug.Log(this.GetComponent<RectTransform>().position);
    }
    public void temp()
    {
        Debug.Log("funciona el caso de soltar");
    }
}
