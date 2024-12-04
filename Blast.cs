using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blast : MonoBehaviour
{
    private Transform player;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position, player.position, speed * Time.deltaTime );
    }
    public void OnTriggerEnter2D ()
    {
        Destroy(gameObject);
    }
}
