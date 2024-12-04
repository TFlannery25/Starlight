using System.Collections;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Security.Cryptography;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public GameObject bulletImpact;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

   void OnTriggerEnter2D (Collider2D hitInfo)
    {                                   
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(20);
            Destroy(gameObject);
        }
        if(hitInfo.tag == "Wall")
        {
            Destroy(gameObject);
        }
        if (hitInfo.tag == "Ground")
        {
            Destroy(gameObject);
        }


        //Instantiate(bulletImpact, transform.position, transform.rotation);



    }
}
