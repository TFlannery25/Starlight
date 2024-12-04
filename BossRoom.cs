using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossRoom : MonoBehaviour
{
    public GameObject wall01;
    public GameObject wall02;
    public GameObject boss;
    public GameObject wallspawn01;
    public GameObject wallspawn02;
    public GameObject bossspawn;

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.tag == "Player")
        {
            Instantiate(wall01, wallspawn01.transform.position, wallspawn01.transform.rotation);
            Instantiate(wall02, wallspawn02.transform.position, wallspawn02.transform.rotation);
            Instantiate(boss, bossspawn.transform.position, bossspawn.transform.rotation);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
