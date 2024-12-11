using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireKnightDamage : MonoBehaviour
{
    public float damage = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D hit)
    {
        HealthBar2 enemyHealth = hit.gameObject.GetComponent<HealthBar2>();
        if (enemyHealth != null)
        {
            enemyHealth.takeDamageSword(damage);
            Debug.Log("Damaged");
        }
    }
}
