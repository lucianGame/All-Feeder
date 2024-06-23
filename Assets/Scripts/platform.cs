using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    public GameObject player;
    public GameObject movingPlatform;


    private void OnTriggerEnter(Collider other)
    {
        player.transform.SetParent(movingPlatform.transform);
    }

    private void OnTriggerExit(Collider other)
    {
        player.transform.SetParent(null);
    }
}
