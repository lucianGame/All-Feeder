using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpen : MonoBehaviour
{
    public GameObject door;

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = door.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        anim.SetTrigger("open");
    }
}
