using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    Ray ray;
    RaycastHit hit;
    public LayerMask layerMask;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * 10); 

        if (Physics.Raycast(ray, out hit, 2, layerMask))
        {
            pickupables.near = true;
            Debug.Log("near");
        }

        else
        {
            pickupables.near = false;
        }
    }

}
