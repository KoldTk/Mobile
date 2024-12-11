using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar2 : MonoBehaviour
{
    private float maxHealth = 100f;
    public float currentHealth;
    public HealthBarSlider2 healthbar2;
    public Animator animator;
    private float lifeTime = 60;
    public bool isDead;
    public HealtBar player1Health;
    void Start()
    {
        animator = GetComponent<Animator>();
        currentHealth = maxHealth;
        Debug.Log(currentHealth);
        healthbar2.setMaxhealth2(maxHealth);
    }

    private void Update()
    {
        if (player1Health.isDead && !animator.GetCurrentAnimatorStateInfo(0).IsName("Win"))
        {
            animator.SetTrigger("Win");
        }
    }
    public void takeDamageSword(float damage)
    {
        
        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        if (healthbar2 != null)
        {
            animator.SetTrigger("Hurt");
            healthbar2.setHealth2(currentHealth);
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
