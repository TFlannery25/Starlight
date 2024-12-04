using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOShoot : MonoBehaviour
{
    private Transform player;
    public Transform firePoint;
    public GameObject blast;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void Blast ()
    {
        Instantiate(blast, firePoint.position, firePoint.rotation);
    }
}
