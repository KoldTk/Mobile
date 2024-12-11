using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallControl : MonoBehaviour
{
    public GameObject dragon;
    public Rigidbody2D wall;
    public Animator animator;
    private Vector3 knockback = new Vector3(-0.1f, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        animator.Play("Hurt");
        Debug.Log("You're hit");
        
    }
}
