using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSyringe : MonoBehaviour
{
    public GameObject Syringe;
    public GameObject Ampula;
    public Transform spawnPoint;
    public Transform spawnPointAmpula;
    public void Create()
    {
        Instantiate(Syringe, spawnPoint.position, spawnPoint.rotation);
        Instantiate(Ampula, spawnPointAmpula.position, spawnPointAmpula.rotation);
    }
}
