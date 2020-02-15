using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class BorrarItem : MonoBehaviour
{
    public GameObject temp;
    public Button boton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left) // Checks if left mouse button is pressed
        {
            print("left");
        }
        else if (eventData.button == PointerEventData.InputButton.Right) // checks if right mouse button is pressed
        {
            print("Right");
        }

    }
}
