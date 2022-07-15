using UnityEngine;

public class changechar : MonoBehaviour
{
    public int selectchar=0;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        SelectCharchter();
    }

   
    void Update()
    {
        int priv=selectchar;
        if (Input.GetKey(KeyCode.Alpha1))
        {
            selectchar=0;
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            selectchar=1;
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            selectchar=2;
            rb.isKinematic = true; 

        }
        if(priv != selectchar)
        {
            
            SelectCharchter();
        }
    }

    void SelectCharchter()
    {
        int i=0;
        foreach(Transform charr in transform)
        {
            if(i==selectchar)
                charr.gameObject.SetActive(true);
            else
                charr.gameObject.SetActive(false);

            i++;
        }

    }
}
