using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadOpenMouth : MonoBehaviour
{
    [SerializeField] private Animator animator; // Reference to the Animator component on the player object


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetBool("hitCollider", true);
        }
    }

    private void OnTriggerExit(Collider other) 
    {
        if (other.CompareTag("Player"))
        {
            animator.SetBool("hitCollider", false);

        }
    }
}
