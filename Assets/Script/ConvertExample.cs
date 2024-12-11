using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int num = 10;
        double doubleNum = num;
        float floatnum = 10.5f;
        num = (int)floatnum;

        Debug.Log(num);


        string a = "12304";
        var numb = int.Parse(a);
        Debug.Log(numb);

        int b = 97;
        var numa = Convert.ToChar(b);
        Debug.Log(numa);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
