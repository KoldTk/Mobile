using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;
using Image = UnityEngine.UI.Image;

public class StartGameMenu : MonoBehaviour
{
    [SerializeField] private Button playButton;
    [SerializeField] private Image image;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPlayClick()
    {
        Time.timeScale = 1;
        playButton.gameObject.SetActive(false);
        image.enabled = false;
    }    

}
