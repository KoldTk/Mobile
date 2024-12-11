using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageExample1 : MonoBehaviour
{
    [SerializeField] private Image originalImage;
    [SerializeField] private Sprite targetImage;
    // Start is called before the first frame update
    void Start()
    {
        originalImage.sprite = targetImage;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
