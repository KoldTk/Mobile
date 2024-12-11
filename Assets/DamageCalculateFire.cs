using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class DamageCalculateFire : MonoBehaviour
{
    public float damage = 10f;

    private void OnCollisionEnter2D(Collision2D hit)
    {
        Debug.Log("Collision detected with: " + hit.gameObject.name);

            HealtBar charHealth = hit.gameObject.GetComponent<HealtBar>();
            if (charHealth != null)
            {
                Debug.Log("Applying damage to player.");
                charHealth.takeDamage(damage);
            }
            else
            {
                Debug.Log("Nothing");
            }
    }
}
