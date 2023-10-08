using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;
using UnityEngine.InputSystem;

public class SterilizeSyringe : MonoBehaviour
{
    public InputActionReference inputPrimatyButton;
    public SterilizeField ser;
    public Injection inj;
    public AudioSource audi;

    void Update()
    {
        if (inputPrimatyButton.action.IsPressed() && inj.mlFloat < 1.9f)
        {
            inj.mlFloat = 2f;
            audi.Play();
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, 0.197f);
        }
        else if (inputPrimatyButton.action.IsPressed() && ser.dropped)
        { 
            ser.dropped = false;
            inj.mlFloat = 2f;
            audi.Play();
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, 0.197f);
        }
    }
}
