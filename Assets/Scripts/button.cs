using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public GameObject platform;
    public GameObject bigButton;

    private Animator anim;
    private Animator buttonAnim;

    private void Start()
    {
        anim = platform.GetComponent<Animator>();
        buttonAnim = bigButton.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        anim.SetTrigger("move");
        buttonAnim.SetTrigger("down");
    }

    private void OnTriggerExit(Collider other)
    {
        anim.SetTrigger("still");
        buttonAnim.SetTrigger("up");
    }
}
