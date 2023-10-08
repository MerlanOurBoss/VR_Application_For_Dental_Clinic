using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddAmpula : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ampula"))
        {
            collision.gameObject.SetActive(false);

            EnableChildObjectsWithTag(transform, "Detail");
        }
    }

    private void EnableChildObjectsWithTag(Transform parent, string tag)
    {
        foreach (Transform child in parent)
        {
            if (child.CompareTag(tag))
            {
                child.gameObject.SetActive(true);
            }
            EnableChildObjectsWithTag(child, tag);
        }
    }
}
