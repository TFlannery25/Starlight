using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    public GameObject nextlevel;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Delete");
    }

    IEnumerator Delete()
    {
        float time = 1;
        yield return new WaitForSeconds(time);
        Instantiate(nextlevel, transform.position, transform.rotation);
        Destroy(gameObject);
    }
    
}
