using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheel : MonoBehaviour
{
   public Vector3 rotation=new Vector3(0f,1f,0f);
    void Update()
    {
        transform.Rotate(rotation);
    }
}
