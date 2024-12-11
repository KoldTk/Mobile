using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using Unity.VisualScripting;
using UnityEngine;

public class HealtBar : MonoBehaviour
{
    private float maxHealth = 100f;
    public float currentHealth;
    public HealthBarSlider healthbar;
    public Animator animator;
    private float lifeTime = 60;
    public HealthBar2 player2Health;
    public bool isDead;
    

    void Start()
    {
        animator = GetComponent<Animator>();
        currentHealth = maxHealth;
        healthbar.setMaxhealth(maxHealth);

    }

    private void Update()
    {
        if (player2Health.isDead && !animator.GetCurrentAnimatorStateInfo(0).IsName("Win"))
        {
            animator.SetTrigger("Win");
            
        }
    }
    public void takeDamage(float damage)
    {
        currentHealth -= damage;
        
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        if (healthbar != null)
        {
            animator.SetTrigger("Hurt");
            healthbar.setHealth(currentHealth);
        }
        
        if (currentHealth == 0)
        {
            isDead = true;
            animator.SetTrigger("Die");
            Debug.Log("Dead");
            Destroy(gameObject, lifeTime * Time.deltaTime);
        }   
    }
}
