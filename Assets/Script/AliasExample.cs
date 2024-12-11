using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ProjectAlias = System.Collections.Generic.Dictionary<string, int>;

public class AliasExample : MonoBehaviour
{
    [SerializeField] private ProjectAlias dictionary;
    void Start()
    {
        dictionary = new ProjectAlias();
        dictionary["0"] = 1;
        dictionary["1"] = 2;
        Debug.Log("Value for Key1: " + dictionary["1"]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
