using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    public GameObject fireBall;
    public Rigidbody2D fireBallBody;
    public SpriteRenderer sprite;
    public Animator animator;
    [SerializeField] private float firespeed;
    Vector3 move = new Vector3(1,0,0);
    public float lifetime;
    private Vector2 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        fireBallBody.transform.localScale = transform.localScale;
    }
    public void SetMoveDirection(Vector3 direction)
    {
        moveDirection = direction;
    }

    // Update is called once per frame
    void Update()
    {

            transform.Translate(moveDirection * firespeed * Time.deltaTime);
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetTrigger("crash");
        animator.SetBool("isCrash", true);
        Destroy(fireBall, lifetime * Time.deltaTime);
    }
}
