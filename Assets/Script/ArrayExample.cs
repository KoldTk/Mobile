using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    private int[] numbers = new int[10];
    // Start is called before the first frame update
    void Start()
    {
        numbers[0] = 15;
        numbers[1] = 27;
        numbers[2] = 34;
        numbers[3] = 47;
        numbers[4] = 58;
        numbers[5] = 27;
        numbers[6] = 34;
        numbers[7] = 47;
        numbers[8] = 58;
        numbers[9] = 47;


        // Iterating through the array
        for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log($"{numbers.Length}");
            Debug.Log("Element " + i + ": " + numbers[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
