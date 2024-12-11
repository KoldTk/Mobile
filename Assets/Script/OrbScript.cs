using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrbScript : MonoBehaviour
{
    [SerializeField] private Text Redtxt;
    [SerializeField] private Text Bluetxt;
    [SerializeField] private Text Greentxt;
    [SerializeField] private Text Goldxt;
    [SerializeField] private Text Rainbowtxt;
    [SerializeField] private Text Silvertxt;
    [SerializeField]private string Red;
    [SerializeField] private string Blue;
    [SerializeField] private string Green;
    [SerializeField] private string Gold;
    [SerializeField] private string Rainbow;
    [SerializeField] private string Silver;

    // Start is called before the first frame update
    void Start()
    {
        Redtxt.text = Red;
        Bluetxt.text = Blue;
        Greentxt.text = Green;
        Goldxt.text = Gold;
        Rainbowtxt.text = Rainbow;
        Silvertxt.text = Silver;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
