using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportExit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Destroy");
    }

    
    public IEnumerator Destroy ()
    {
        float time = 1;
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}
