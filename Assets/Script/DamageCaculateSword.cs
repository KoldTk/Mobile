using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class DamageCaculateSword : MonoBehaviour
{
    public float damage = 10f;
    // Start is called before the first frame update
    private void Start()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D hit)
    {
        HealthBar2 enemyHealth = hit.gameObject.GetComponent<HealthBar2>();
        if (enemyHealth != null)
        {
            enemyHealth.takeDamageSword(damage);
        }
    }
}
