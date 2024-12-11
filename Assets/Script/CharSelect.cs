using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CharSelect : MonoBehaviour
{
    [SerializeField] private ScrollRect scrollView;
    // Start is called before the first frame update
    void Start()
    {
        scrollView.verticalNormalizedPosition = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnButtonClick()
    {
        Debug.Log("Select Character");
    }    

}
