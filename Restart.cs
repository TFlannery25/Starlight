using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("RestartLevel");
    }

        IEnumerator RestartLevel()
        {
            float time = 2;
            yield return new WaitForSeconds(time);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        }
}
