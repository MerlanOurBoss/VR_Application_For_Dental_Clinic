using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftHandMove : MonoBehaviour
{
    public Animator anim;

    private void Start()
    {
        anim.Play("LeftHandAnimation2");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Syringe"))
        {
            anim.Play("LeftHandAnimation");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Syringe"))
        {
            anim.Play("LeftHandAnimation2");
        }
    }
}
