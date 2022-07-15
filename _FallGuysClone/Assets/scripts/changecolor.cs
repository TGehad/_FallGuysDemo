using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changecolor : MonoBehaviour
{
    Color32 c = new Color32(251, 255, 0, 255);

   private Renderer rend;
    void Start()
    {
        rend=GetComponent<Renderer>();

    }

    void OnCollisionEnter(Collision collision)    
    {
    if(collision.gameObject.tag =="Player")
    {    
        rend.material.SetColor("_Color",c);

    }
    }
}
