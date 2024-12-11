using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("This is a log message.");
        Debug.LogWarning("This is a warning message.");
        Debug.LogError("This is an error message.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
