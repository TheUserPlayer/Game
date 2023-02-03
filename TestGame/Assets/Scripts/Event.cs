using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Event : MonoBehaviour
{
   private int fruitNumber ;
   public static int fruitNumberNowApple = 0 ;
   public static int fruitNumberNowPeach = 0 ;
   public static int fruitNumberNowPear = 0 ;
   private int amountOffruit;
   public Text EventText;
   public GameObject Con;
   public GameObject Bacet;
   public IKControl Final;
   public GameObject CameraMain;
   public GameObject Cam;
    public GameObject Button;

   
   
   private void Start() 
   {
    fruitNumberNowApple = 0;
    fruitNumberNowPeach = 0;
    fruitNumberNowPear = 0;

    fruitNumber = Random.Range(1, 4);
    amountOffruit = Random.Range(1, 5);
    NumbUpdate();
    
   }
   public void NumbUpdate() 
   {
    if(fruitNumber == 1)
    {
        EventText.text = "Apple"+fruitNumberNowApple +"/" + amountOffruit;
        if(fruitNumberNowApple >= amountOffruit)
        {
            
            GameOver();
            
            
        }
    }
    else if(fruitNumber == 2)
    {
        EventText.text = "Peach"+fruitNumberNowPeach +"/" + amountOffruit;
        if(fruitNumberNowPeach >= amountOffruit)
        {
            GameOver();
            
        }
    }
    
    else if(fruitNumber == 3)
    {
        EventText.text = "Pear"+fruitNumberNowPear +"/" + amountOffruit;
        if(fruitNumberNowPear >= amountOffruit)
        {
            GameOver();
            
        }
    }
  }
  

  private void DestroyApplPeachPear()
  {
    var objs = GameObject.FindGameObjectsWithTag( "Destroi" ); // возвращает МАССИВ!
           for( int i = 0; i < objs.Length; i++ )
            {
                Destroy( objs[ i ] );
            }
  }
  private void GameOver()
  {
    IKControl.N++;
    DestroyApplPeachPear();
    Invoke("Dens",0.7f);
    Debug.Log("Win");
  }
  private void Dens()
  {
    EventText.text = "Level Passed";
    Bacet.SetActive(false);
    Con.SetActive(false);
    CameraMain.SetActive(false);
    Button.SetActive(true);
    Cam.SetActive(true);
    Final.FinalAnim();
  }
}


   

