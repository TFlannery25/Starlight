using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 250;

    public GameObject deathEffect;

    public GameObject healOrb;

    //public GameObject deathEffect

    

    public void TakeDamage (int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die ()
    {
        Instantiate(deathEffect, transform.position, transform.rotation);
        Instantiate(healOrb, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
