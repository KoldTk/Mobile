using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerExit2D(Collider2D die)
    {
        HealtBar player1 = die.gameObject.GetComponent<HealtBar>();
        HealthBar2 player2 = die.gameObject.GetComponent<HealthBar2>();

        if (player1 != null)
        {
            player1.isDead = true;
        }
        else if (player2 != null)
        {
            player2.isDead = true;
        }
    }
}
