using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class Bin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Syringe"))
        {
            XRGrabInteractable xr = other.gameObject.GetComponent<XRGrabInteractable>();
            xr.enabled = false;
        }
    }
}
