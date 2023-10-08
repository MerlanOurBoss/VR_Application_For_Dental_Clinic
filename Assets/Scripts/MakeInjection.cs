using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MakeInjection : MonoBehaviour
{
    public bool hitDesna = false;
    public Material myDesna;
    public Color hitColor;
    public Color missedColor;
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Desna"))
        {
            hitDesna = true;
            Debug.Log("hitted");
            myDesna.color = Color.green;
        }
    }

    private void OnTriggerExit(Collider other)
    {
            hitDesna = false;
            Debug.Log("not hitted");
            myDesna.color = Color.red;
    }
}
