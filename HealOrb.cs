using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealOrb : MonoBehaviour
{
    
    public void OnTriggerEnter2D (Collider2D hitInfo)
    {
        if (hitInfo.tag == "Player")
        {
            Heal();
            Destroy(gameObject);
        }
    }
    void Heal ()
    {
        FindObjectOfType<CharacterController2D>().Healing(20);
        
    }
}
