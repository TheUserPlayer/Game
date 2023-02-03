using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body : MonoBehaviour
{
    public  Transform BodyObj = null;
    void Update()
    {
        if(BodyObj != null)
        { 
        transform.LookAt(BodyObj);
        }
    }
}
