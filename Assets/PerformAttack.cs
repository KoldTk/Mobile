using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerformAttack : MonoBehaviour
{
    public GameObject swordAttack;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            performAttack();
        }
    }

    void performAttack()
    {
        GameObject attack = Instantiate(swordAttack, transform.position, transform.rotation);
    }

}
