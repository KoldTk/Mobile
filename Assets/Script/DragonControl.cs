using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DragonControl : MonoBehaviour
{
    public GameObject dragon;
    public Rigidbody2D physic;
    public SpriteRenderer sprite;
    public BoxCollider2D dragonCollider;
    [SerializeField] private float gamespeed;
    Vector3 jump = new Vector3(0, 1, 0);
    Vector3 dash = new Vector3(1, 0, 0);
    Vector3 moveleft = new Vector3(-1, 0, 0);
    Vector3 moveright = new Vector3(1, 0, 0);
    [SerializeField] private float jumpforce;
    public Animator animator;
    public GameObject fireSpawn;
    public LayerMask ground;
    private bool onGround;
    private bool canJump = true;
    private bool isIdle;
    private bool isJumping;
    private bool isWalking;
    private bool isCrouching;
    private bool isAttacking;
    private bool isDashing;
    // Start is called before the first frame update
    void Start()
    {
        isIdle = true;
        isJumping = false;
        isWalking = false;
        isCrouching = false;
        isAttacking = false;
        isDashing = false;
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        fireSpawn.transform.localScale = transform.localScale;
        dragonCollider = GetComponent<BoxCollider2D>();
        MoveControl();
        AttackControl();
        if (Input.GetKeyDown(KeyCode.KeypadEnter) && onGround && canJump)
        {
            CharacterJump();
        }
    }
    void MoveControl()
    {
        animator.SetBool("isIdle", true);
        animator.SetBool("onGround", true);
        if (Input.GetKey(KeyCode.LeftArrow) && !isCrouching && !isAttacking && !isDashing)
        {
            isWalking = true;
            animator.SetBool("isIdle", false);
            animator.SetTrigger("walk");
            animator.SetBool("isWalking", true);
            dragon.transform.Translate(moveleft * Time.deltaTime * gamespeed);
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if (Input.GetKey(KeyCode.RightArrow) && !isCrouching && !isAttacking && !isDashing)
        {
            isWalking = true;
            animator.SetBool("isIdle", false);
            animator.SetTrigger("walk");
            animator.SetBool("isWalking", true);
            dragon.transform.Translate(moveright * Time.deltaTime * gamespeed);
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {   
            isCrouching = true;
            isWalking = false;
            animator.SetTrigger("crouch");
            animator.SetBool("isIdle", false);
            animator.SetBool("isCrouch", true);
            dragonCollider.size = new Vector2(0.5f, 0.9f);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.DownArrow) )
        {
            animator.SetBool("isIdle", true);
            animator.SetBool("isWalking", false);
            animator.SetBool("isCrouch", false);
            dragonCollider.size = new Vector2(0.5f, 1.2f);
            isIdle = true;
            isWalking = false;
            isDashing = false;
        }
    }
    void AttackControl()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1) && animator.GetBool("onGround"))
        {
            animator.SetBool("isIdle", false);
            animator.SetTrigger("attack");
            animator.SetBool("isAttacking", true);
        }
        if (Input.GetKeyUp(KeyCode.Keypad1) || Input.GetKeyUp(KeyCode.Keypad2))
        {
            if (animator.GetBool("onGround"))
            {
                animator.SetBool("isIdle", true);
                animator.SetBool("isAttacking", false);
            }
            if (animator.GetBool("onAir"))
            {
                animator.SetBool("isAttacking", false);
            }
            if (animator.GetBool("isCrouch"))
            {
                animator.SetBool("isAttacking", false);
            }
        }
        if (Input.GetKeyDown(KeyCode.Keypad1) && !onGround)
        {
            animator.SetTrigger("attack");
            animator.SetBool("isAttacking", true);
        }
        if (Input.GetKeyDown(KeyCode.Keypad2) && !onGround)
        {
            animator.SetTrigger("flyKick");
            animator.SetBool("isAttacking", true);
        }
        if (Input.GetKeyDown(KeyCode.Keypad1) && isCrouching)
        {
            animator.SetTrigger("crouchAttack");
            animator.SetBool("isAttacking", true);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (animator.GetBool("onAir"))
        {
            animator.SetBool("isIdle", true);
            animator.SetBool("onAir", false);
        }

        if (collision.gameObject.layer == 4)
        {
            onGround = true;
            canJump = true;
        }
    }
    void CharacterJump()
    {
        physic.velocity = new Vector2(physic.velocity.x, jumpforce);
        canJump = false;
        onGround = false;
        animator.SetTrigger("jump");
        animator.SetBool("onAir", true);
        
    }
}
