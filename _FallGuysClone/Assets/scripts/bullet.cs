using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public Vector3 velo=new Vector3(0,0,-5000);
    private Rigidbody rb;

    void Start()
    {
         rb=GetComponent<Rigidbody>();
         
    }
    void FixedUpdate()
    {

    rb.AddForce(velo*Time.deltaTime);

    }

   
    
}
