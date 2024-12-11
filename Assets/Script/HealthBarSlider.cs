using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarSlider : MonoBehaviour
{
    [SerializeField] private Slider healthBar1;
    private void Start()
    {
        
    }


    public void setMaxhealth(float health)
    {
        healthBar1.maxValue = health;
        healthBar1.value = health;
        Debug.Log($"Healbar: {healthBar1.value}");

        
    }
        
    public void setHealth(float health)
    {
        healthBar1.value = health;
    }

}
