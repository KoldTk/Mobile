using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Score2 : MonoBehaviour
{
    [SerializeField] private double score2 = 0;
    // Start is called before the first frame update
    void Start()
    {
        switch (score2)
        {
            case 100:
                Debug.Log("Xếp hạng: A");
                break;
            case 90:
                Debug.Log("Xếp hạng: B");
                break;
            case 80:
                Debug.Log("Xếp hạng: C");
                break;
            case 70:
                Debug.Log("Xếp hạng: D");
                break;
            default:
                Debug.Log("Không có xếp hạng");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
