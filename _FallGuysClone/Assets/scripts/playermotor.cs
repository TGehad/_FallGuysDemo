using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermotor : MonoBehaviour
{
    public float MoveSpeed=5f;
    public float RotatSpeed=5f;
    private Vector3 MoveDirection;
    private CharacterController MyCh;
    
   

    void Start()
    {
        MyCh=GetComponent<CharacterController>();
    }

   
    void Update()
    {
        rotate();
        Move();
        MoveDirection=transform.TransformDirection(MoveDirection);
        MyCh.Move(MoveDirection*Time.deltaTime);

        
    }

    void Move()
    {
        MoveDirection.z=MoveDirection.x=0;  
        MoveDirection += new Vector3 (0,0,Input.GetAxis("Vertical")*MoveSpeed);
    }

    void rotate()
    {
        transform.Rotate(0,RotatSpeed * Input.GetAxis("Horizontal"),0);

    }

    
  
  
}
