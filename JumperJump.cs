using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CapsuleCollider2D))]

public class JumperJump : MonoBehaviour
{
    // Move player in 2D space
    public float maxSpeed = 3.4f;
    public float jumpHeight = 6.5f;
    public float gravityScale = 1.5f;
    public float dashSpeed = 6.5f;
    
    

    bool facingRight = true;
    float moveDirection = 0;
    public bool isGrounded = false;
    Vector3 cameraPos;
    Rigidbody2D r2d;
    Collider2D mainCollider;
    // Check every collider except Player and Ignore Raycast
    LayerMask layerMask = ~(1 << 2 | 1 << 8);
    Transform t;

    bool facingLeft = false;

    //Animations
    public Animator animator;

    // Use this for initialization
    void Start()
    {
        t = transform;
        r2d = GetComponent<Rigidbody2D>();
        mainCollider = GetComponent<Collider2D>();
        r2d.freezeRotation = true;
        r2d.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
        r2d.gravityScale = gravityScale;
        facingRight = t.localScale.x > 0;
        gameObject.layer = 8;

        
    }

    // Update is called once per frame
    void Update()
    {
        

        

        


        // Jumping
        if (isGrounded)
        {
            r2d.velocity = new Vector2(r2d.velocity.x, jumpHeight);
            
            animator.SetBool("IsJumping", false);
        }
        else
        {
            animator.SetBool("IsJumping", true);
        }



        


        
    }

    void FixedUpdate()
    {
        Bounds colliderBounds = mainCollider.bounds;
        Vector3 groundCheckPos = colliderBounds.min + new Vector3(colliderBounds.size.x * 0.5f, 0.1f, 0);
        // Check if player is grounded
        isGrounded = Physics2D.OverlapCircle(groundCheckPos, 0.23f, layerMask);

        // Apply movement velocity
        r2d.velocity = new Vector2((moveDirection) * maxSpeed, r2d.velocity.y);

        // Simple debug
        //Debug.DrawLine(groundCheckPos, groundCheckPos - new Vector3(0, 0.23f, 0), isGrounded ? Color.green : Color.red);



    }

    public void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "Ground")
        {
            animator.SetBool("IsJumping", false);
        }







    }
}
