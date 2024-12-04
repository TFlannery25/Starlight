using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOTrigger : MonoBehaviour
{
    public Animator animator;
    void OnTriggerEnter2D(Collider2D collision)
    {
       

        if (collision.CompareTag("Player"))
        {
            //FindObjectOfType<UFOShoot>().Blast();
            //GetComponent<UFOShoot>().Blast();
            animator.SetBool("Attacking", true);
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            animator.SetBool("Attacking", false);
        }
    }
}
