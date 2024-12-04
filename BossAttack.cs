using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack : MonoBehaviour
{
    private Transform player;
    public float speed;
    private Transform boss;
    // Start is called before the first frame update
    void Start()
    {
        boss = gameObject.transform;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        boss.transform.position = Vector3.MoveTowards(boss.transform.position, player.position, speed * Time.deltaTime);
    }
}
