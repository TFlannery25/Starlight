using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("LevelUp");
    }

    IEnumerator LevelUp()
    {
        float time = 1;
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
