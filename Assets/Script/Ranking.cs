using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ranking : MonoBehaviour
{
    string[] name = { "Alice", "Bob", "Charlie", "Diana", "Ethan" };
    string[] score = { "5", "19", "29", "8", "12" };
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < name.Length; i++) 
        {
            Debug.Log($"{name[i]} : {score[i]}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AddPlayer()
    {

    }    
}
