using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringExample : MonoBehaviour
{
    [SerializeField] private string message;
    [SerializeField] private string greeting;
    [SerializeField] private string name;
    [SerializeField] private string welcome;
    // Start is called before the first frame update
    void Start()
    {
        greeting = "Hello, " + "World!";
        name = "Unity";
        welcome = $"Welcome to {name} programming!";
        message = "Hello!";
        string newstring = "greeting";
        welcome.Replace("Welcome", newstring);
        Debug.Log(welcome.Substring(8, 2));
        Debug.Log(name.ToUpper());
        Debug.Log(greeting.ToLower());
        Debug.Log(message);
        Debug.Log(greeting);
        Debug.Log(welcome.Length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
