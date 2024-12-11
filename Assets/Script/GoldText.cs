using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldText : MonoBehaviour
{
    [SerializeField] private Text goldtxt;
    [SerializeField] private Text silvertxt;
    [SerializeField] private string gold;
    [SerializeField] private string silver;
    // Start is called before the first frame update
    void Start()
    {
        goldtxt.text = gold;
        silvertxt.text = silver;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
