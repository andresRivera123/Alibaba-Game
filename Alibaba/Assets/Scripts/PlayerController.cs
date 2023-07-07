using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float runSpeed = 1.75f;
    [SerializeField] float jumpSpeed = 3;

    [SerializeField] bool betterJump = false;
    [SerializeField] float fallMultiplier = 0.5f;
    [SerializeField] float lowJumpMultiplier = 1f;
    Rigidbody2D rg2D;
    Animator animator;

    void Start()
    {
        rg2D = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
       
    }


    void FixedUpdate()
    {


        if (Input.GetKey("left")|| Input.GetKey("a"))
        {
            rg2D.velocity = new Vector2(-runSpeed, rg2D.velocity.y);
            GetComponent<SpriteRenderer>().flipX = true;
            animator.SetBool("Run", true);
        }
        else if (Input.GetKey("right") || Input.GetKey("d"))
        {
            rg2D.velocity = new Vector2(runSpeed, rg2D.velocity.y);
            GetComponent<SpriteRenderer>().flipX = false;
            animator.SetBool("Run", true);
        }
        else
        {
            rg2D.velocity = new Vector2(0, rg2D.velocity.y);
            animator.SetBool("Run", false);

        }
        if (Input.GetKey("space")&& IsGround.isGround)
        {
            rg2D.velocity = new Vector2(rg2D.velocity.x, jumpSpeed);

        }

        if (IsGround.isGround == false)
        {
            animator.SetBool("Jump", true);
            animator.SetBool("Run", false);
        }
        if (IsGround.isGround == true)
        {
            animator.SetBool("Jump", false);
        }


        if (betterJump)
        {
            if (rg2D.velocity.y < 0)
            {
                rg2D.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier) * Time.deltaTime;
            }
            if (rg2D.velocity.y > 0 && !Input.GetKey("up"))
            {
                rg2D.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier) * Time.deltaTime;
            }
        }
    }

}
