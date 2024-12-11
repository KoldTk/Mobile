using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"Time since application start: {Time.time} ");
        Debug.Log($"Time between frames:{Time.deltaTime} ");
    }
}
