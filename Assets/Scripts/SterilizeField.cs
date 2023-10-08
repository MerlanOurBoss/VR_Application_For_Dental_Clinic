using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SterilizeField : MonoBehaviour
{
    public bool dropped = false;
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Syringe"))
        {
            dropped = true;
        }
    }
}
