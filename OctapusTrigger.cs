using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class OctapusTrigger : MonoBehaviour
{
    public Animator animator;
    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            animator.SetBool("Chasing", true);
        }
    }
}
