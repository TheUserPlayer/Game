using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basket : MonoBehaviour
{
    public GameObject AppleObj;
    public GameObject AppleObj2;
    public GameObject AppleObj3;
    public GameObject AppleObj4;
    public GameObject AppleObj5;
    public GameObject pearObj;
    public GameObject pearObj2;
    public GameObject pearObj3;
    public GameObject pearObj4;
    public GameObject pearObj5;
    public GameObject PeachObj;
    public GameObject PeachObj2;
    public GameObject PeachObj3;
    public GameObject PeachObj4;
    public GameObject PeachObj5;
    private int FrAppl = 0;
    private int Frpear = 0;
    private int FrPeach = 0;
    
        public void InvokeTimeApple()
        {
            Invoke("BasketFApple",0.6f);
        }
        public void InvokeTimepear()
        {
            Invoke("BasketFpear",0.6f);
        }
        public void InvokeTimePeach()
        {
            Invoke("BasketFPeach",0.6f);
        }
        
        public void BasketFApple()
        {
            FrAppl ++;
            if(FrAppl == 1)AppleObj.SetActive(true);
            else if(FrAppl == 2)AppleObj2.SetActive(true);
            else if(FrAppl == 3)AppleObj3.SetActive(true);
            else if(FrAppl == 4)AppleObj4.SetActive(true);
            else if(FrAppl == 5)AppleObj5.SetActive(true);
        }
        public void BasketFpear()
        {
            Frpear ++;
            if(Frpear == 1)pearObj.SetActive(true);
            else if(Frpear == 2)pearObj2.SetActive(true);
            else if(Frpear == 3)pearObj3.SetActive(true);
            else if(Frpear == 4)pearObj4.SetActive(true);
            else if(Frpear == 5)pearObj5.SetActive(true);
        }
        public void BasketFPeach()
        {
            FrPeach ++;
            if(FrPeach == 1)PeachObj.SetActive(true);
            else if(FrPeach == 2)PeachObj2.SetActive(true);
            else if(FrPeach == 3)PeachObj3.SetActive(true);
            else if(FrPeach == 4)PeachObj4.SetActive(true);
            else if(FrPeach == 5)PeachObj5.SetActive(true);
        }
}
