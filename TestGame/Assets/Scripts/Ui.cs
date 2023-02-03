using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ui : MonoBehaviour
{
    public GameObject UI1;
    private Animator Anim;
    void Start()
    {
        Anim = GetComponent<Animator>();
        
    }
    public void UiAnimatorControl()
    {
        Anim.Play("Ui");
        
    }
    
}
