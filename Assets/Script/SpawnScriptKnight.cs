using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class SpawnScriptKnight : MonoBehaviour
{
    public GameObject FireSpawnright;
    public Transform spawnLocation;
    public float chargeTime;
    public float chargeSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.J))
        {
            SpawnFireBall();
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            chargeTime = 0;
        }
    }

    void SpawnFireBall()
    {
        chargeTime += chargeSpeed;
        if (chargeTime >= 500)
        {
            GameObject fireball = Instantiate(FireSpawnright, transform.position, transform.rotation);
            fireball.transform.localScale = transform.localScale;
            Vector2 moveDirection = Vector2.right;

            if (transform.localScale.x < 0)
            {
                moveDirection = Vector2.left;
            }
            FireBallKnight fireBallMove = fireball.GetComponent<FireBallKnight>();
            if (fireBallMove != null)
            {
                fireBallMove.SetMoveDirection(moveDirection);
            }
            chargeTime = 0;
        }

    }
}
