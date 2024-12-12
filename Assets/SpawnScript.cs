using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SpawnScript : MonoBehaviour
{
    public GameObject FireSpawnright;
    public Transform spawnLocation;
    public float length; //Duration between action
    public float interval; //Count the time between two action


    // Start is called before the first frame update
    void Start()
    {

        interval = length;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(interval >= length && Input.GetKeyDown(KeyCode.Keypad1))
        {
            SpawnFireBall();
            interval = 0;
        }
        if (interval <= length)
        {
            interval += Time.deltaTime;
        }
            

    }

    void SpawnFireBall()
    {
        GameObject fireball = Instantiate(FireSpawnright, transform.position, transform.rotation);
        fireball.transform.localScale = transform.localScale;
        Vector2 moveDirection = Vector2.right;

        if (transform.localScale.x < 0)
        {
            moveDirection = Vector2.left;
        }
        FireBall fireBallMove = fireball.GetComponent<FireBall>();
        if (fireBallMove != null)
        {
            fireBallMove.SetMoveDirection(moveDirection);
        }
    }
}
