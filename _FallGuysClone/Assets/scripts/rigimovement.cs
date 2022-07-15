using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigimovement : MonoBehaviour
{
    private Rigidbody rb;
    public float forwardForce =10f;
    private Vector3 inputVector;
    public Vector3 jumpvec = new Vector3(0.0f, 1f, 0.0f);
    public float jumpForce = 10f; 
    //public float RotatSpeed=6f;
    public bool isGrounded;

    void Start()
    {
     rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
    inputVector=new Vector3(Input.GetAxis("Horizontal")*forwardForce,0,Input.GetAxis("Vertical")*forwardForce);
    transform.LookAt(transform.position+ new Vector3(inputVector.x,0,inputVector.z));  
    
    
    }
    void FixedUpdate()
    {
    rb.velocity=inputVector;
    if(Input.GetKeyDown(KeyCode.Space))
    {
        jump();
    }

    }
    
   

     

    void jump()
    {
    
    rb.velocity=jumpvec;
    isGrounded = false;
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }
    void OnCollisionExit()
    {
        isGrounded = false;
    }

  

}
