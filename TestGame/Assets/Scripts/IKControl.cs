using UnityEngine;
using System;
using System.Collections;

[RequireComponent(typeof(Animator))] 

public class IKControl : MonoBehaviour {
    
    protected Animator animator;
    public static int N = 0;
    public bool ikActive = false;
    private Transform rightHandObj = null;
    private Transform lookObj = null;
    public GameObject AppleObj;
    public GameObject PearObj;
    public GameObject PeachObj;
    //public Transform BodyObj = null;
    public float Rig;
   

    void Start () 
    {
        N = 0;
        animator = GetComponent<Animator>();
        
        
    }
    
    void OnAnimatorIK()
    {
        if(animator) {
           
          
             
            if(ikActive) {
                
                

                
                if(lookObj != null) 
                {
                    animator.SetLookAtWeight(1);
                    animator.SetLookAtPosition(lookObj.position);
                }    

                
                if(rightHandObj != null) 
                {
                    animator.SetIKPositionWeight(AvatarIKGoal.RightHand,Rig);
                    animator.SetIKRotationWeight(AvatarIKGoal.RightHand,Rig);  
                    animator.SetIKPosition(AvatarIKGoal.RightHand,rightHandObj.position);
                    animator.SetIKRotation(AvatarIKGoal.RightHand,rightHandObj.rotation);
                    //Body1.transform.LookAt(BodyObj.transform.position);
                   
                }
                
                      
                
            }
            
            
            else {          
                animator.SetIKPositionWeight(AvatarIKGoal.RightHand,0);
                animator.SetIKRotationWeight(AvatarIKGoal.RightHand,0); 
                animator.SetLookAtWeight(0);
            }
        }
    }
    private void Update() 
    {
        if(N == 0)
        {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.CompareTag("Apple"))
                {
                    
                    
                     rightHandObj = hit.transform;
                     lookObj = hit.transform;
                    //BodyObj = hit.transform;
                     
                     
                    ikActive = true;
                   Debug.Log("Yasss");
                }
                else if (hit.transform.CompareTag("Peach"))
                {
                    
                    
                     rightHandObj = hit.transform;
                     lookObj = hit.transform;
                    //BodyObj = hit.transform;
                     
                     
                    ikActive = true;
                   Debug.Log("Yasss");
                }
                else if (hit.transform.CompareTag("pear"))
                {
                    
                     rightHandObj = hit.transform;
                     lookObj = hit.transform;
                    //BodyObj = hit.transform;
                     
                     
                    ikActive = true;
                   Debug.Log("Yasss");
                }
                else 
            {
                ikActive = false;
                 Debug.Log("Noo");
            }
            }
         
        }
        }
        else
        { return;
        }
    }

     public void AnimPlayApple()
    {
        
        ikActive = false;
        AppleObj.SetActive(true);
        animator.Play("1");
        animator.Play("idle");
    }
    public void AnimPlayPear()
    {
        
        ikActive = false;
        PearObj.SetActive(true);
        animator.Play("Pear");
        animator.Play("idle");
    }
    public void AnimPlayPeach()
    {
        
        ikActive = false;
        PeachObj.SetActive(true);
        animator.Play("Peach");
        animator.Play("idle");
    }
    public void FinalAnim()
    {
        animator.Play("Swing Dancing (1)");
    }
   
}
