using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarSlider2 : MonoBehaviour
{
    [SerializeField] Slider healthBar2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setMaxhealth2(float health)
    {
        healthBar2.maxValue = health;
        healthBar2.value = health;

        Debug.Log($"Healbar: {healthBar2.value}");
    }
    public void setHealth2(float health)
    {
        healthBar2.value = health;
    }
}
