using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumperTrigger : MonoBehaviour
{
    public Transform player;
    public GameObject jumper;
    public float speed;
    public Transform jumpper;

    void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        
    }

    void Update()
    {
       
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Attack();
        }


    }
    void Attack ()
    {

        
        jumpper.transform.position = Vector3.MoveTowards(jumpper.transform.position, player.position , speed * Time.deltaTime);

    }
}
