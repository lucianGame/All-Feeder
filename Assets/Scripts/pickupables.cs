using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupables : MonoBehaviour
{
    public GameObject cube;
    public Camera mainCamera;

    float cubePos = 0.15f;
    float distance = 0.7f;

    public static bool near;

    public Rigidbody rb;

    private void Start()
    {
        rb = cube.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E) && near)
        {
            rb.isKinematic = true;
            cube.transform.SetParent(mainCamera.transform);
            cube.transform.position = mainCamera.transform.position + mainCamera.transform.forward * distance;

        }

        else
        {
            rb.isKinematic = false;
            cube.transform.SetParent(null);
        }
    }
}
