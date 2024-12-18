﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bullet;
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        else 
        {
            animator.SetBool("Shooting", false);
        }
    }

    void Shoot ()
    {
        animator.SetBool("Shooting", true);
        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }
}

