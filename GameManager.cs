using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float time;
    
    
    public IEnumerator Restart()
    {
        float time = 1;
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }

    public void NextLevel ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Quit ()
    {
        Application.Quit();
    }



}
