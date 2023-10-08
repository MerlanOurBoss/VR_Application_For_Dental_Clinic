using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SyringeInput : MonoBehaviour
{
    public Rigidbody rb;
    public AudioSource myAudioWin;
    private bool isTriggered = false;
    public Injection injection;
    private float curMlFloat;
    public bool isMlFloat = false;
    public float moveSpeed = 10f;

    public bool isInjectionInserted = false;
    public bool iglaScaling = false;
    public Transform iglaObject;

    private bool tubiralina1Trig = false;
    private Vector3 velocity = Vector3.zero;

    public Material rotren;
    public Material rotrenFace;

    public Texture rot_texture;

    public Texture face_texture;
    private void Awake()
    {
        myAudioWin = GameObject.Find("Main Camera").GetComponentInChildren<AudioSource>();
        rotren.mainTexture = rot_texture;
        rotrenFace.mainTexture = face_texture;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Infiltrazionaia_Trigger") 
            || other.CompareTag("Infiltrazionaia_Trigger2")
            || other.CompareTag("Infiltrazionaia_Trigger3")
            || other.CompareTag("Infiltrazionaia_Trigger4")
            || other.CompareTag("Infiltrazionaia_Trigger5")
            || other.CompareTag("Infiltrazionaia_Trigger6")
            || other.CompareTag("Rezsova_Trigger") 
            || other.CompareTag("Tubiralina_Trigger")
            || other.CompareTag("Tubiralina_Trigger2")
            || other.CompareTag("Nebnaia_Trigger")
            || other.CompareTag("Nebnaia_Trigger2")
            || other.CompareTag("Mentalinaia_Trigger")
            || other.CompareTag("Mentalinaia_Trigger2")
            || other.CompareTag("Mandibuliarnaia_Trigger")
            || other.CompareTag("Mandibuliarnaia_Trigger2"))
        {
            curMlFloat = injection.mlFloat;
        }
    }
    private void Update()
    {
        if (!iglaScaling)
        {
            iglaObject.localScale = new Vector3(50.13618f, 50.13618f, 50.13618f);
        }
        else
        {
            iglaObject.localScale = new Vector3(101.4029f, 50.13618f, 50.13618f);
        }
    }
    public void IsInjectionInserted()
    {
        isInjectionInserted = false;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Infiltrazionaia_Trigger"))
        {
            iglaScaling = false;
            ColliderFreeze cold = other.gameObject.GetComponent<ColliderFreeze>();
            isTriggered = true;
            transform.rotation = Quaternion.Euler(new Vector3(22f, 90f, 0f));
            transform.position = new Vector3(-31.402f, 4.2226f, 40.8385f);
            rb.constraints = RigidbodyConstraints.FreezeAll;
            if (injection.mlFloat > 0.4f)
            {
                if (injection.mlFloat < curMlFloat - 0.4f)
                {
                    rotren.mainTexture = rot_texture;
                    cold.injectionIns();
                    rb.constraints = RigidbodyConstraints.None;
                    ScoreImplementiing.Instance.AddingScore(50);
                    myAudioWin.Play();
                }
            }
            else
            {
                
                isMlFloat = true;
                injection.mlControll();
                rb.constraints = RigidbodyConstraints.None;
                transform.position = new Vector3(-31.133f, 4.28f, 40.84f);
            }
        }
        else if (other.CompareTag("Infiltrazionaia_Trigger2"))
        {
            iglaScaling = false;
            ColliderFreeze cold = other.gameObject.GetComponent<ColliderFreeze>();
            isTriggered = true;
            transform.rotation = Quaternion.Euler(new Vector3(-45f, 90f, 0f));
            transform.position = new Vector3(-31.4203f, 4.0502f, 40.841f);
            rb.constraints = RigidbodyConstraints.FreezeAll;
            if (injection.mlFloat > 0.4f)
            {
                if (injection.mlFloat < curMlFloat - 0.4f)
                {
                    rotren.mainTexture = rot_texture;
                    cold.injectionIns();
                    isInjectionInserted = true;
                    rb.constraints = RigidbodyConstraints.None;
                    ScoreImplementiing.Instance.AddingScore(50);
                    myAudioWin.Play();
                }
            }
            else
            {
                isMlFloat = true;
                injection.mlControll();
                rb.constraints = RigidbodyConstraints.None;
                transform.position = new Vector3(-31.133f, 4.28f, 40.84f);
            }
        }
        else if (other.CompareTag("Infiltrazionaia_Trigger3"))
        {
            iglaScaling = false;
            ColliderFreeze cold = other.gameObject.GetComponent<ColliderFreeze>();
            isTriggered = true;
            transform.rotation = Quaternion.Euler(new Vector3(-10f, 45f, 0f));
            transform.position = new Vector3(-31.8665f, 3.9973f, 40.776f);
            rb.constraints = RigidbodyConstraints.FreezeAll;
            if (injection.mlFloat > 0.4f)
            { 
                if (injection.mlFloat < curMlFloat - 0.4f)
                {
                    rotren.mainTexture = rot_texture;
                    cold.injectionIns();
                    isInjectionInserted = true;
                    rb.constraints = RigidbodyConstraints.None;
                    ScoreImplementiing.Instance.AddingScore(100);
                    myAudioWin.Play();
                }

            }
            else
            {
                isMlFloat = true;
                injection.mlControll();
                rb.constraints = RigidbodyConstraints.None;
                transform.position = new Vector3(-31.133f, 4.28f, 40.84f);
            }
        }
        else if (other.CompareTag("Infiltrazionaia_Trigger4"))
        {
            iglaScaling = false;
            ColliderFreeze cold = other.gameObject.GetComponent<ColliderFreeze>();
            isTriggered = true;
            transform.rotation = Quaternion.Euler(new Vector3(-10f, 135f, 0f));
            transform.position = new Vector3(-31.8175f, 4.0025f, 40.9542f);
            rb.constraints = RigidbodyConstraints.FreezeAll;
            if (injection.mlFloat > 0.4f)
            {
                if (injection.mlFloat < curMlFloat - 0.4f)
                {
                    rotren.mainTexture = rot_texture;
                    cold.injectionIns();
                    isInjectionInserted = true;
                    rb.constraints = RigidbodyConstraints.None;
                    ScoreImplementiing.Instance.AddingScore(100);
                    myAudioWin.Play();
                }

            }
            else
            {
                isMlFloat = true;
                injection.mlControll();
                rb.constraints = RigidbodyConstraints.None;
                transform.position = new Vector3(-31.133f, 4.28f, 40.84f);
            }
        }
        else if (other.CompareTag("Infiltrazionaia_Trigger5"))
        {
            iglaScaling = false;
            ColliderFreeze cold = other.gameObject.GetComponent<ColliderFreeze>();
            isTriggered = true;
            transform.rotation = Quaternion.Euler(new Vector3(45f, 105f, 10f));
            transform.position = new Vector3(-31.5596f, 4.0046f, 40.8844f);
            rb.constraints = RigidbodyConstraints.FreezeAll;
            if (injection.mlFloat > 0.4f)
            {
                if (injection.mlFloat < curMlFloat - 0.4f)
                {
                    rotren.mainTexture = rot_texture;
                    cold.injectionIns();
                    isInjectionInserted = true;
                    rb.constraints = RigidbodyConstraints.None;
                    ScoreImplementiing.Instance.AddingScore(75);
                    myAudioWin.Play();
                }

            }
            else
            {
                isMlFloat = true;
                injection.mlControll();
                rb.constraints = RigidbodyConstraints.None;
                transform.position = new Vector3(-31.133f, 4.28f, 40.84f);
            }
        }
        else if (other.CompareTag("Infiltrazionaia_Trigger6"))
        {
            iglaScaling = false;
            ColliderFreeze cold = other.gameObject.GetComponent<ColliderFreeze>();
            isTriggered = true;
            transform.rotation = Quaternion.Euler(new Vector3(45f, 78f, -8f));
            transform.position = new Vector3(-31.5788f, 4.0053f, 40.8149f);
            rb.constraints = RigidbodyConstraints.FreezeAll;
            if (injection.mlFloat > 0.4f)
            {
                if (injection.mlFloat < curMlFloat - 0.4f)
                {
                    rotren.mainTexture = rot_texture;
                    cold.injectionIns();
                    isInjectionInserted = true;
                    rb.constraints = RigidbodyConstraints.None;
                    ScoreImplementiing.Instance.AddingScore(75);
                    myAudioWin.Play();
                }

            }
            else
            {
                isMlFloat = true;
                injection.mlControll();
                rb.constraints = RigidbodyConstraints.None;
                transform.position = new Vector3(-31.133f, 4.28f, 40.84f);
            }
        }
        else if (other.CompareTag("Rezsova_Trigger"))
        {
            iglaScaling = false;
            ColliderFreeze cold = other.gameObject.GetComponent<ColliderFreeze>();
            isTriggered = true;
            transform.rotation = Quaternion.Euler(new Vector3(45f, 90f, 0f));
            transform.position = new Vector3(-31.534f, 4.045f, 40.8434f);
            rb.constraints = RigidbodyConstraints.FreezeAll;
            if (injection.mlFloat > 0.4f)
            {
                if (injection.mlFloat < curMlFloat - 0.4f)
                {
                    rotren.mainTexture = rot_texture;
                    cold.injectionIns();
                    isInjectionInserted = true;
                    rb.constraints = RigidbodyConstraints.None;
                    ScoreImplementiing.Instance.AddingScore(100);
                    myAudioWin.Play();
                }

            }
            else
            {
                isMlFloat = true;
                injection.mlControll();
                rb.constraints = RigidbodyConstraints.None;
                transform.position = new Vector3(-31.133f, 4.28f, 40.84f);
            }

        }
        else if (other.CompareTag("Tubiralina_Trigger"))
        {
            iglaScaling = false;
            ColliderFreeze cold = other.gameObject.GetComponent<ColliderFreeze>();
            isTriggered = true;
            transform.rotation = Quaternion.Euler(new Vector3(45f, 80f, -33.5f));
            transform.position = new Vector3(-31.6783f, 3.968f, 41.1929f);
            rb.constraints = RigidbodyConstraints.FreezeAll;
            if (curMlFloat > 1.9f)
            {
                if (injection.mlFloat < curMlFloat - 0.05f)
                {
                    transform.position = Vector3.MoveTowards(transform.position, new Vector3(-31.697f, 3.987f, 41.19f), moveSpeed * Time.deltaTime);

                    if (injection.mlFloat < curMlFloat - 0.15f)
                    {
                        transform.rotation = Quaternion.Euler(new Vector3(39.103f, 84.927f, -30.194f));
                        transform.position = Vector3.MoveTowards(transform.position, new Vector3(-31.6858f, 4.0103f, 41.1768f), moveSpeed * Time.deltaTime);

                        if (injection.mlFloat < curMlFloat - 0.25f)
                        {
                            transform.rotation = Quaternion.Euler(new Vector3(35.086f, 77.057f, -34.948f));
                            transform.position = Vector3.MoveTowards(transform.position, new Vector3(-31.687f, 4.032f, 41.198f), moveSpeed * Time.deltaTime);

                            if (injection.mlFloat < curMlFloat - 1.9f)
                            {
                                rotren.mainTexture = rot_texture;
                                cold.injectionIns();
                                isInjectionInserted = true;
                                rb.constraints = RigidbodyConstraints.None;
                                ScoreImplementiing.Instance.AddingScore(100);
                                myAudioWin.Play();
                            }
                        }
                    }   
                }
            }
            else
            {
                isMlFloat = true;
                injection.mlControll();
                rb.constraints = RigidbodyConstraints.None;
                transform.position = new Vector3(-31.133f, 4.28f, 40.84f);
            }
        }
        else if (other.CompareTag("Tubiralina_Trigger2"))
        {
            iglaScaling = false;
            ColliderFreeze cold = other.gameObject.GetComponent<ColliderFreeze>();
            isTriggered = true;
            transform.rotation = Quaternion.Euler(new Vector3(45f, 84f, 0f));
            transform.position = new Vector3(-31.721f, 3.943f, 40.59f);
            rb.constraints = RigidbodyConstraints.FreezeAll;

            if (curMlFloat > 1.9f)
            {
                if (injection.mlFloat < curMlFloat - 0.05f)
                {
                    transform.position = Vector3.MoveTowards(transform.position, new Vector3(-31.738f, 3.96f, 40.588f), moveSpeed * Time.deltaTime);

                    if (injection.mlFloat < curMlFloat - 0.15f)
                    {
                        transform.rotation = Quaternion.Euler(new Vector3(37.331f, 85.298f, 0.787f));
                        transform.position = Vector3.MoveTowards(transform.position, new Vector3(-31.725f, 3.998f, 40.581f), moveSpeed * Time.deltaTime);

                        if (injection.mlFloat < curMlFloat - 0.25f)
                        {
                            transform.rotation = Quaternion.Euler(new Vector3(36.776f, 95.536f, 6.967f));
                            transform.position = Vector3.MoveTowards(transform.position, new Vector3(-31.734f, 4.008f, 40.545f), moveSpeed * Time.deltaTime);

                            if (injection.mlFloat < curMlFloat - 1.9f)
                            {
                                rotren.mainTexture = rot_texture;
                                cold.injectionIns();
                                isInjectionInserted = true;
                                rb.constraints = RigidbodyConstraints.None;
                                ScoreImplementiing.Instance.AddingScore(100);
                                myAudioWin.Play();
                            }
                        }
                    }
                }
            }
            else
            {
                isMlFloat = true;
                injection.mlControll();
                rb.constraints = RigidbodyConstraints.None;
                transform.position = new Vector3(-31.133f, 4.28f, 40.84f);
            }
        }
        else if (other.CompareTag("Nebnaia_Trigger"))
        {
            iglaScaling = false;
            ColliderFreeze cold = other.gameObject.GetComponent<ColliderFreeze>();
            isTriggered = true;
            transform.rotation = Quaternion.Euler(new Vector3(12f, 45f, 3f));
            transform.position = new Vector3(-31.7098f, 4.0467f, 40.9107f);
            rb.constraints = RigidbodyConstraints.FreezeAll;
           if (injection.mlFloat > 0.4f)
            {
                if (injection.mlFloat < curMlFloat - 0.05f)
                {
                    transform.position = Vector3.MoveTowards(transform.position, new Vector3(-31.7194f, 4.0496f, 40.9011f), moveSpeed * Time.deltaTime);

                    if (injection.mlFloat < curMlFloat - 0.15f)
                    {
                        transform.rotation = Quaternion.Euler(new Vector3(11.836f, 47.914f, 3.602f));
                        transform.position = Vector3.MoveTowards(transform.position, new Vector3(-31.713f, 4.0503f, 40.8937f), moveSpeed * Time.deltaTime);

                        if (injection.mlFloat < curMlFloat - 0.25f)
                        {
                            transform.rotation = Quaternion.Euler(new Vector3(11.641f, 50.83f, 4.195f));
                            transform.position = Vector3.MoveTowards(transform.position, new Vector3(-31.7118f, 4.0535f, 40.8759f), moveSpeed * Time.deltaTime);

                            if (injection.mlFloat < curMlFloat - 0.4f)
                            {
                                rotren.mainTexture = rot_texture;
                                cold.injectionIns();
                                isInjectionInserted = true;
                                rb.constraints = RigidbodyConstraints.None;
                                ScoreImplementiing.Instance.AddingScore(75);
                                myAudioWin.Play();
                            }
                        }
                    }
                }
            }
            else
            {
                isMlFloat = true;
                injection.mlControll();
                rb.constraints = RigidbodyConstraints.None;
                transform.position = new Vector3(-31.133f, 4.28f, 40.84f);
            }
        }
        else if (other.CompareTag("Nebnaia_Trigger2"))
        {
            iglaScaling = false;
            ColliderFreeze cold = other.gameObject.GetComponent<ColliderFreeze>();
            isTriggered = true;
            transform.rotation = Quaternion.Euler(new Vector3(12f, 135f, 0f));
            transform.position = new Vector3(-31.6771f, 4.0438f, 40.8026f);
            rb.constraints = RigidbodyConstraints.FreezeAll;
            if (injection.mlFloat > 0.4f)
            {
                if (injection.mlFloat < curMlFloat - 0.05f)
                {
                    transform.position = Vector3.MoveTowards(transform.position, new Vector3(-31.6885f, 4.0472f, 40.814f), moveSpeed * Time.deltaTime);

                    if (injection.mlFloat < curMlFloat - 0.15f)
                    {
                        transform.rotation = Quaternion.Euler(new Vector3(11.988f, 132.363f, -0.548f));
                        transform.position = Vector3.MoveTowards(transform.position, new Vector3(-31.6882f, 4.049f, 40.8263f), moveSpeed * Time.deltaTime);

                        if (injection.mlFloat < curMlFloat - 0.25f)
                        {
                            transform.rotation = Quaternion.Euler(new Vector3(11.993f, 136.95f, 0.405f));
                            transform.position = Vector3.MoveTowards(transform.position, new Vector3(-31.7133f, 4.0531f, 40.8288f), moveSpeed * Time.deltaTime);

                            if (injection.mlFloat < curMlFloat - 0.4f)
                            {
                                rotren.mainTexture = rot_texture;
                                cold.injectionIns();
                                isInjectionInserted = true;
                                rb.constraints = RigidbodyConstraints.None;
                                ScoreImplementiing.Instance.AddingScore(75);
                                myAudioWin.Play();
                            }
                        }
                    }
                }
            }
            else
            {
                isMlFloat = true;
                injection.mlControll();
                rb.constraints = RigidbodyConstraints.None;
                transform.position = new Vector3(-31.133f, 4.28f, 40.84f);
            }
        }
        else if (other.CompareTag("Mentalinaia_Trigger"))
        {
            iglaScaling = true;
            ColliderFreeze cold = other.gameObject.GetComponent<ColliderFreeze>();
            isTriggered = true;
            transform.rotation = Quaternion.Euler(new Vector3(-134.138f, -182.718f, 110f));
            transform.position = new Vector3(-31.749f, 4.134f, 41.303f);
            rb.constraints = RigidbodyConstraints.FreezeAll;

            if (injection.mlFloat > 0.4f)
            {
                if (injection.mlFloat < curMlFloat - 0.4f)
                {
                    rotrenFace.mainTexture = face_texture;
                    cold.injectionIns();
                    isInjectionInserted = true;
                    rb.constraints = RigidbodyConstraints.None;
                    ScoreImplementiing.Instance.AddingScore(75);
                    myAudioWin.Play();
                }

            }
            else
            {
                isMlFloat = true;
                injection.mlControll();
                rb.constraints = RigidbodyConstraints.None;
                transform.position = new Vector3(-31.133f, 4.28f, 40.84f);
            }
        }
        else if (other.CompareTag("Mentalinaia_Trigger2"))
        {
            iglaScaling = true;
            ColliderFreeze cold = other.gameObject.GetComponent<ColliderFreeze>();
            isTriggered = true;
            transform.rotation = Quaternion.Euler(new Vector3(-134.138f, -355.473f, 110.551f));
            transform.position = new Vector3(-31.777f, 4.1316f, 40.3988f);
            rb.constraints = RigidbodyConstraints.FreezeAll;

            if (injection.mlFloat > 0.4f)
            {
                if (injection.mlFloat < curMlFloat - 0.4f)
                {
                    rotrenFace.mainTexture = face_texture;
                    cold.injectionIns();
                    isInjectionInserted = true;
                    rb.constraints = RigidbodyConstraints.None;
                    ScoreImplementiing.Instance.AddingScore(75);
                    myAudioWin.Play();
                }

            }
            else
            {
                isMlFloat = true;
                injection.mlControll();
                rb.constraints = RigidbodyConstraints.None;
                transform.position = new Vector3(-31.133f, 4.28f, 40.84f);
            }
        }
        else if (other.CompareTag("Mandibuliarnaia_Trigger"))
        {
            iglaScaling = false;
            ColliderFreeze cold = other.gameObject.GetComponent<ColliderFreeze>();
            isTriggered = true;
            transform.rotation = Quaternion.Euler(new Vector3(-13f, 45f, -41f));
            transform.position = new Vector3(-31.9018f, 3.9841f, 40.8522f);
            rb.constraints = RigidbodyConstraints.FreezeAll;

            if (curMlFloat > 1.9f)
            {
                if (injection.mlFloat < curMlFloat - 0.3f)
                {
                    transform.rotation = Quaternion.Euler(-12.99f, 47.344f, -41f);
                    transform.position = new Vector3(-31.8907f, 3.9841f, 40.8406f);
                    Debug.Log("1");

                    if (injection.mlFloat < curMlFloat - 0.4f)
                    {
                        transform.rotation = Quaternion.Euler(-12.111f, 59.975f, -41f);
                        transform.position = new Vector3(-31.8413f, 3.9841f, 40.80922f);

                        if (injection.mlFloat < curMlFloat - 0.5f)
                        {
                            transform.rotation = Quaternion.Euler(-11.601f, 72.224f, -41f);
                            transform.position = new Vector3(-31.8092f, 3.9841f, 40.7554f);
                            Debug.Log("2");

                            if (injection.mlFloat < curMlFloat - 0.7f)
                            {
                                transform.rotation = Quaternion.Euler(-11.601f, 72.224f, -10f);
                                transform.position = new Vector3(-31.8525f, 3.9748f, 40.7415f);
                                Debug.Log("3");

                                if (injection.mlFloat < curMlFloat - 0.9f)
                                {
                                    transform.rotation = Quaternion.Euler(new Vector3(-11.601f, 72.224f, -10f));
                                    transform.position = Vector3.MoveTowards(transform.position, new Vector3(-31.8092f, 3.9841f, 40.7554f), moveSpeed * Time.deltaTime);
                                    Debug.Log("4");

                                    if (injection.mlFloat < curMlFloat - 1.1f)
                                    {
                                        rotren.mainTexture = rot_texture;
                                        cold.injectionIns();
                                        isInjectionInserted = true;
                                        rb.constraints = RigidbodyConstraints.None;
                                        ScoreImplementiing.Instance.AddingScore(200);
                                        myAudioWin.Play();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                isMlFloat = true;
                injection.mlControll();
                rb.constraints = RigidbodyConstraints.None;
                transform.position = new Vector3(-31.133f, 4.28f, 40.84f);
            }
        }
        else if (other.CompareTag("Mandibuliarnaia_Trigger2"))
        {
            iglaScaling = false;
            ColliderFreeze cold = other.gameObject.GetComponent<ColliderFreeze>();
            isTriggered = true;
            transform.rotation = Quaternion.Euler(new Vector3(-13f, 45f, -41f));
            transform.position = new Vector3(-31.9018f, 3.9841f, 40.8522f);
            rb.constraints = RigidbodyConstraints.FreezeAll;

            if (curMlFloat > 1.9f)
            {
                if (injection.mlFloat < curMlFloat - 0.3f)
                {
                    transform.rotation = Quaternion.Euler(-12.99f, 47.344f, -41f);
                    transform.position = new Vector3(-31.8907f, 3.9841f, 40.8406f);
                    Debug.Log("1");

                    if (injection.mlFloat < curMlFloat - 0.4f)
                    {
                        transform.rotation = Quaternion.Euler(-12.111f, 59.975f, -41f);
                        transform.position = new Vector3(-31.8413f, 3.9841f, 40.80922f);

                        if (injection.mlFloat < curMlFloat - 0.5f)
                        {
                            transform.rotation = Quaternion.Euler(-11.601f, 72.224f, -41f);
                            transform.position = new Vector3(-31.8092f, 3.9841f, 40.7554f);
                            Debug.Log("2");

                            if (injection.mlFloat < curMlFloat - 0.7f)
                            {
                                transform.rotation = Quaternion.Euler(-11.601f, 72.224f, -10f);
                                transform.position = new Vector3(-31.8525f, 3.9748f, 40.7415f);
                                Debug.Log("3");

                                if (injection.mlFloat < curMlFloat - 0.9f)
                                {
                                    transform.rotation = Quaternion.Euler(new Vector3(-11.601f, 72.224f, -10f));
                                    transform.position = Vector3.MoveTowards(transform.position, new Vector3(-31.8092f, 3.9841f, 40.7554f), moveSpeed * Time.deltaTime);
                                    Debug.Log("4");

                                    if (injection.mlFloat < curMlFloat - 1.1f)
                                    {
                                        rotren.mainTexture = rot_texture;
                                        cold.injectionIns();
                                        isInjectionInserted = true;
                                        rb.constraints = RigidbodyConstraints.None;
                                        ScoreImplementiing.Instance.AddingScore(200);
                                        myAudioWin.Play();
                                    }
                                }
                            }
                        }
                    }
                }
            }

            else
            {
                isMlFloat = true;
                injection.mlControll();
                rb.constraints = RigidbodyConstraints.None;
                transform.position = new Vector3(-31.133f, 4.28f, 40.84f);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Infiltrazionaia_Trigger"))
        {
            isTriggered = false;
            isInjectionInserted = false;
        }
        else if (other.CompareTag("Rezsova_Trigger"))
        {
            isTriggered = false;
        }
        else if (other.CompareTag("Tubiralina_Trigger"))
        {
            isTriggered = false;
        }
        else if (other.CompareTag("Nebnaia_Trigger"))
        {
            isTriggered = false;
        }
        else if (other.CompareTag("Mentalinaia_Trigger"))
        {
            isTriggered = false;
        }
    }

    //public void IncreasePoints(int amount)
    //{
    //    scoreValue += amount;
    //}
}
