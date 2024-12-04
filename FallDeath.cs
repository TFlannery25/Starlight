using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDeath : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        if (hitInfo.tag == "Player")
        {
            FindObjectOfType<CharacterController2D>().Death();
        }
    }
}
