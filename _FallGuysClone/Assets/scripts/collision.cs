using UnityEngine;

public class collision : MonoBehaviour
{
   public float MoveSpeed =300f;
   private Rigidbody rb;
   private bool ismoving=true;

   void Start()
   {
       rb=GetComponent<Rigidbody>();
        
   }

    void FixedUpdate()
    {
        if(ismoving==true)
        {
        Move();
        }
        else
        {
        invMove();
        }


    }

    void OnCollisionEnter(Collision collisioninfo)
    {
  
     if(collisioninfo.collider.tag =="end")
       {    
        
        ismoving=!ismoving;

       }
    }

    void Move()
    {
        rb.AddForce(MoveSpeed*Time.deltaTime,0,0);
    }
    
    void invMove()
    {

        rb.AddForce(-MoveSpeed*Time.deltaTime,0,0);
    }


}
