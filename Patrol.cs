﻿using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public Transform pos1, pos2;
    public float speed;
    public Transform startPos;
    Vector3 nextPos;

    public Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        nextPos = startPos.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == pos1.position)
        {
            nextPos = pos2.position;
            transform.Rotate(0, 180, 0);
        }
        if (transform.position == pos2.position)
        {
            nextPos = pos1.position;
            transform.Rotate(0, 180, 0);
            
        }
        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);

    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(pos1.position, pos2.position);
    }
}
