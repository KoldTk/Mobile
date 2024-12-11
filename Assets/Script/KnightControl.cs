using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class KnightControl : MonoBehaviour
{
    public GameObject knight;
    public Rigidbody2D physic;
    public GameObject hitBox;
    [SerializeField] private float gamespeed;
    [SerializeField] private float dashspeed;
    Vector3 jump = new Vector3 (0,1,0);
    Vector3 dash = new Vector3 (1,0,0);
    Vector3 moveleft = new Vector3(-1, 0, 0);
    Vector3 moveright = new Vector3(1, 0, 0);
    [SerializeField] private float jumpforce;
    public SpriteRenderer sprite;
    public Animator animator;
    public Animator dashEffect;
    private bool isDashing;
    public SpriteRenderer dashSprite;
    public GameObject fireSpawn;
    public LayerMask ground;
    private bool onGround;
    private bool canJump = true;
    private bool isIdle;
    private bool isJumping;
    private bool isWalking;
    private bool isCrouching;
    private bool isAttacking;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        
        physic = GetComponent<Rigidbody2D>();
        isIdle = true;
        isJumping = false;
        isWalking = false;
        isCrouching = false;
        isAttacking = false;
        isDashing = false;

    }

    // Update is called once per frame
    void Update()
    {
        fireSpawn.transform.localScale = transform.localScale;
        MoveControl();
       AttackControl();
       ControlDash();
        if (Input.GetKeyDown(KeyCode.Space) && canJump  && onGround)
        {
            CharacterJump();
            onGround = false;
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
    private void ControlDash()
    {
        dashEffect.enabled = false;
        dashSprite.enabled = false;

        if (isDashing && !dashEffect.enabled)
        {
            dashSprite.enabled = true;
            dashEffect.enabled = true;
        }
        if (!isDashing && dashEffect.enabled)
        {
            dashSprite.enabled = false;
            dashEffect.enabled = false;
        }
    }
    void AttackControl()
    {
        if (Input.GetKeyDown(KeyCode.H) && !isWalking)
        {
            isAttacking = true;
            animator.SetBool("isIdle", false);
            animator.SetTrigger("attack");
            animator.SetBool("isAttacking", true);
        }
        if (Input.GetKey(KeyCode.J) && !isWalking)
        {
            isAttacking = true;
            animator.SetBool("isIdle", false);
            animator.SetTrigger("cast");
            animator.SetBool("isAttacking", true);
        }
        if (Input.GetKeyDown(KeyCode.K) && !isWalking && !isCrouching && onGround)
        {
            isAttacking = true;
            animator.SetBool("isIdle", false);
            animator.SetTrigger("block");
            animator.SetBool("isAttacking", true);
        }
        if (Input.GetKeyDown(KeyCode.H) && !onGround)
        {
            isAttacking = true;
            animator.SetTrigger("attack");
            animator.SetBool("isAttacking", true);
            hitBox.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.H) && isWalking)
        {
            isAttacking = true;
            animator.SetTrigger("attack");
            animator.SetBool("isAttacking", true);
        }    
        if (Input.GetKeyUp(KeyCode.H) || Input.GetKeyUp(KeyCode.J) || Input.GetKeyUp(KeyCode.K) && animator.GetBool("isAttacking"))
        {
            isAttacking = false;
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
        
    }
    void CharacterJump()
    {
        physic.velocity = new Vector2 (physic.velocity.x, jumpforce);
        canJump = false;
        animator.SetTrigger("jump");
        animator.SetBool("onAir", true);
        
    }
    void MoveControl()
    {   
        animator.SetBool("isIdle", true);
        animator.SetBool("isDashing", false);
    if (Input.GetKey(KeyCode.A) && !isCrouching && !isAttacking && !isDashing)
    {
        isAttacking = false;
        isWalking = true;
        animator.SetBool("isIdle", false);
        animator.SetTrigger("walk");
        animator.SetBool("isWalking", true);
        knight.transform.Translate(moveleft * Time.deltaTime * gamespeed);
        transform.localScale = new Vector3(-1, 1, 1);
        if (Input.GetKeyDown(KeyCode.L) && !isJumping && onGround)
            {
                isDashing = true;
                animator.SetTrigger("dash");
                animator.SetBool("isDashing", true);
                knight.transform.Translate(dash * Time.deltaTime * dashspeed * -1);
                
                
            }
        }
    if (Input.GetKeyDown(KeyCode.L) && !animator.GetBool("isDashing") && !isAttacking && !isCrouching && onGround)
        {
            isDashing = true;
            animator.SetBool("isIdle", false);
            animator.SetTrigger("dash");
            animator.SetBool("isDashing", true);
            if (transform.localScale.x >= 0)
            {
                knight.transform.Translate(dash * Time.deltaTime * dashspeed);
            }else
            {
                knight.transform.Translate(dash * Time.deltaTime * dashspeed * -1);
            }
        }    
    if (Input.GetKey(KeyCode.D) && !isCrouching && !isAttacking && !isDashing)
    {
            isWalking = true;
            animator.SetBool("isIdle", false);
        animator.SetTrigger("walk");
        animator.SetBool("isWalking", true);
        knight.transform.Translate(moveright * Time.deltaTime * gamespeed);
        transform.localScale = new Vector3(1, 1, 1);
            if (Input.GetKeyDown(KeyCode.L) && !isJumping && onGround)
            {
                animator.SetTrigger("dash");
                animator.SetBool("isDashing", true);
                knight.transform.Translate(dash * Time.deltaTime * dashspeed);
                isDashing=true;
            }
        }
    if (Input.GetKey(KeyCode.S))
    {
            isCrouching = true;
            isWalking = false;
            animator.SetTrigger("crouch");
            animator.SetBool("isIdle", false);
            animator.SetBool("isCrouch", true);
            
    }

        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.L))
        {
            animator.SetBool("isIdle", true);
            animator.SetBool("isWalking", false);
            animator.SetBool("isCrouch", false);
            animator.SetBool("isDashing", false);
            isIdle = true;
            isWalking = false;
            isDashing = false;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            isCrouching = false;
        }
    }
    
}
