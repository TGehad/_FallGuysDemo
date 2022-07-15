using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disapear : MonoBehaviour
{
     Color32 c = new Color32(255, 255, 255, 255);

    private Renderer rend;
    void Start()
    {
        rend=GetComponent<Renderer>();

    }
    void OnCollisionEnter(Collision collision)    
    {
    if(collision.gameObject.tag =="Player")
    {    

        Destroy(gameObject,1);
        rend.material.SetColor("_Color",c);

    }
    }
}
