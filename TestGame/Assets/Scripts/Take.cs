using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class Take : MonoBehaviour
{
    public Rig Item_rig;
    public float Hand_Spead;
    int Id_take;
    private Animator anim;
   
    private void Start() {
        anim = GetComponent<Animator>();
    }
    
    void Update()
    {
        
        if ( Input.GetMouseButtonDown(0))
        {
            
            Id_take = 1;
           
        }  
        else if (Input.GetMouseButtonDown(1)) Id_take = 2;
        if(Id_take == 1)
        {
            Item_rig.weight = Mathf.MoveTowards(Item_rig.weight,1,Hand_Spead * Time.deltaTime);
            if(Item_rig.weight == 1) Id_take = 0;
        }
        else if (Id_take == 2)
        {
            Item_rig.weight = Mathf.MoveTowards(Item_rig.weight,0,Hand_Spead * Time.deltaTime);
            if(Item_rig.weight == 0) Id_take = 0;
        }
       
   
        /*if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.CompareTag("Apple"))
                {
                   Debug.Log("Yasss");
                }
                else 
            {
                 Debug.Log("Noo");
            }
            }
            
        }*/
    }
   public void TakeAplle()
   {
    anim.Play("pickup");
    Id_take = 2;
     Debug.Log("Good");
   }
   
}
    