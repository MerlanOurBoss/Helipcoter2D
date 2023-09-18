using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interac : MonoBehaviour
{
    private void Update()
    {

        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.up, out hit, 3))
        {
            if (hit.collider.tag == "Battery")
            {                  
                hit.collider.GetComponent<Batery>().Power();
                Debug.Log("Power collect");
            }
            
        }
    }
}
