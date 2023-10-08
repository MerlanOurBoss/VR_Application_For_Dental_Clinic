using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;


public class Injection : MonoBehaviour
{
    public float distance = 0.0001f;
    public bool activatedTrigger = false;
    public Text mlText;
    public float mlFloat = 2f;
    public InputActionReference inputPrimatyButton;
    public Text mutext;
    public GameObject muImage;
    public SyringeInput syringeInput;

    private void FixedUpdate()
    {
        mlText.text = mlFloat.ToString("0.0" + " ml");
        if (activatedTrigger)
        {
            MoveObject();
            mlFloat = mlFloat - 0.0015f;
        }

        if (transform.localPosition.z < -1.29 || syringeInput.isMlFloat || mlFloat < 0.01)
        {
            deactivateBool();
            if (inputPrimatyButton.action.IsPressed())
            {
                syringeInput.isMlFloat = false;
                muImage.SetActive(false);
                mlFloat = 2f;
                transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, 0.197f);
            }
        }

    }
    public void mlControll()
    {
        muImage.SetActive(true);
        mlText.text = "Not enough";
    }
    public void activatBool()
    {
        activatedTrigger = true;
        Debug.Log("Activated");
    }
    public void deactivateBool()
    {
        activatedTrigger = false;
    }
    public void MoveObject()
    {
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z - distance * Time.fixedDeltaTime);
    }
}
