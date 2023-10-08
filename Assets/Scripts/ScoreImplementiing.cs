using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreImplementiing : MonoBehaviour
{
    public Text scoreValue;
    public static ScoreImplementiing Instance;
    int scoreAdd = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            transform.parent = null;
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Update()
    {
        scoreValue.text = scoreAdd.ToString();  
    }

    public void AddingScore(int value)
    {
        scoreAdd += value;
    }
}
