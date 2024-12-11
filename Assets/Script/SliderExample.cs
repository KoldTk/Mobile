using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderExample : MonoBehaviour
{
    [SerializeField] private Slider value;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Slider: {value}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
