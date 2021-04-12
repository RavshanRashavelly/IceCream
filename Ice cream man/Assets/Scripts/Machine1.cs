using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Machine1 : MonoBehaviour
{

    public GameObject Machine;
   
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Truff")
        {
            Destroy(col.gameObject);
        }

    }

}
