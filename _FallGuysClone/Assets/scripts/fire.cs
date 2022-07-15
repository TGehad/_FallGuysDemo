using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
  
  public GameObject Bullet;
  public float nexttime;
  public float delay=1f; 
   


  void Update()
  {
        
    if(readytospwan)
    {
    nexttime=Time.time+delay;
    Instantiate(Bullet,transform.position,Quaternion.identity);
    }
  }
    
  bool readytospwan => Time.time>=nexttime;
  
}
