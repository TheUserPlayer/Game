using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    //public GameObject UIText;
    public IKControl TakeScriptKI;
    public basket BasketScript;
    public Ui UiScript;
    public Event UpdateFruits;
    

    private void OnTriggerEnter(Collider other) 
        {
            if(other.tag == "Apple")
            {
                Event.fruitNumberNowApple++;
                Debug.Log("Apple");
                UpdateFruits.NumbUpdate();
                UiScript.UiAnimatorControl();
                BasketScript.InvokeTimeApple();
                TakeScriptKI.AnimPlayApple();
            }
            if(other.tag == "pear")
            {
                
                Event.fruitNumberNowPear++;
                Debug.Log("pear");
                UpdateFruits.NumbUpdate();
                UiScript.UiAnimatorControl();
                BasketScript.InvokeTimepear();
                TakeScriptKI.AnimPlayPear();
            }
            if(other.tag == "Peach")
            {
                Event.fruitNumberNowPeach++;
                Debug.Log("Peach");
                UpdateFruits.NumbUpdate();
                UiScript.UiAnimatorControl();
                BasketScript.InvokeTimePeach();
                TakeScriptKI.AnimPlayPeach();
            }
    
        }
}
