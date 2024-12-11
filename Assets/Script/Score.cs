using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField ] private double score = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (score >= 0 && score <= 3)
        {
            Debug.Log("Xếp hạng: D");
        }
        else if (score > 3 && score <= 5)
        {
            Debug.Log("Xếp hạng: C");
        }
        else if (score > 5 && score <= 8)
        {
            Debug.Log("Xếp hạng: B");
        }
        else if (score > 8 && score <= 10)
        {
            Debug.Log("Xếp hạng: A");
        }
        else
        {
            Debug.Log("Điểm không hợp lệ");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
