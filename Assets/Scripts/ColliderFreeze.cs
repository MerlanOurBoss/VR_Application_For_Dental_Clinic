using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ColliderFreeze : MonoBehaviour
{
    public BoxCollider collid;
    private SyringeInput sy;
    public GameObject mySphere;
    public Image myImage;
    public Sprite mySprite;
    public Image YellowImage;


    private void Start()
    {
        sy = GameObject.Find("NovelSyringe").GetComponentInChildren<SyringeInput>();
    }

    public void injectionIns()
    {
        mySphere.SetActive(false);
        collid.enabled = false;
        myImage.sprite = mySprite;
        YellowImage.enabled = false;
    }
}
