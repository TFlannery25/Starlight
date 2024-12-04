    using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CapsuleCollider2D))]

public class CharacterController2D : MonoBehaviour
{
    // Move player in 2D space
    public float maxSpeed = 3.4f;
    public float jumpHeight = 6.5f;
    public float gravityScale = 1.5f;
    public float dashSpeed = 6.5f;
    public Camera mainCamera;
    public Transform firePoint;

    bool facingRight = true;
    float moveDirection = 0;
    bool isGrounded = false;
    Vector3 cameraPos;
    Rigidbody2D r2d;
    Collider2D mainCollider;
    // Check every collider except Player and Ignore Raycast
    LayerMask layerMask = ~(1 << 2 | 1 << 8);
    Transform t;

    bool facingLeft = false;

    //Animations
    public Animator animator;

    //Health
    public int health;
    public GameObject deathEffect;
    public HealthBar healthBar;
    public GameObject restart;

    //Teleport
    public GameObject teleport;

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

        if (mainCamera)
            cameraPos = mainCamera.transform.position;
        healthBar.SetHealth(health);
    }

    // Update is called once per frame
    void Update()
    {
        //Health
        healthBar.SetHealth(health);
        // Movement controls
        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)) && (isGrounded || r2d.velocity.x > 0.01f))
        {
            moveDirection = Input.GetKey(KeyCode.A) ? -1 : 1;
           
            animator.SetFloat("Speed", Mathf.Abs(moveDirection));
        }
        else
        {
            if (isGrounded || r2d.velocity.magnitude < 0.01f)
            {
                moveDirection = 0;
                
                animator.SetFloat("Speed", Mathf.Abs(moveDirection));
            }
        }

        // Change facing direction
        if (moveDirection != 0)
        {
            if (moveDirection > 0 && !facingRight)
            {
                firePoint.transform.Rotate(0f, 0f, 180f);
                facingRight = true;
                t.localScale = new Vector3(Mathf.Abs(t.localScale.x), t.localScale.y, transform.localScale.z);
            }
           if (moveDirection < 0 && facingRight)
            {
                firePoint.transform.Rotate(0f ,0f, 180f);
                facingRight = false;
                 t.localScale = new Vector3(-Mathf.Abs(t.localScale.x), t.localScale.y, t.localScale.z);
            }
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            r2d.velocity = new Vector2(dashSpeed, r2d.velocity.y);
        }


        // Jumping
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            r2d.velocity = new Vector2(r2d.velocity.x, jumpHeight);
            animator.SetBool("IsJumping", true);
            
        }
        
        {
           
        }



        // Camera follow
        if (mainCamera) 
            mainCamera.transform.position = new Vector3(t.position.x, cameraPos.y, cameraPos.z);



        //if (Input.GetKey(KeyCode.A))
        {
            //facingLeft = true;
        }

        //if (Input.GetKey(KeyCode.D))
        {
            //facingLeft = false;
        }


        //if (facingLeft = true)
        {
            //firePoint.rotation.y = 180f;
        }

       // if (facingLeft = false)
        {
            //firePoint.rotation.y = 0f;
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

    public void OnCollisionEnter2D (Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "Ground")
        {
            animator.SetBool("IsJumping", false);
        }
        if (collisionInfo.collider.tag == "Wall")
        {
            animator.SetBool("IsClinging", true);
        } 
        if (collisionInfo.collider.tag == "Enemy")
        {
            Damaged(20);
        }
    }

    
    public void OnCollisionExit2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "Wall")
        {
            animator.SetBool("IsClinging", false);
        }
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.tag == "Enemy")
        {
            Damaged(20);
        }
       
        if (hitInfo.tag == "Teleport")
        {
            Teleport();
        }
    }

    //Player Health
    public void Damaged(int damage)
    {
        health -= damage;
        //healthBar.SetHealth(health);

        if (health <= 0)
        {
            Death();
        }
    }
    public void Healing (int hp)
    {
        if (health < 100)
        {
            health += hp;
        }
    }
    public void Death()
    {
        Instantiate(deathEffect, transform.position, transform.rotation);
        Instantiate(restart, transform.position, transform.rotation);
        Destroy(gameObject);
        
    }

    public void Teleport ()
    {
        Instantiate(teleport, transform.position, transform.rotation);
        Destroy(gameObject);
    }
    













}