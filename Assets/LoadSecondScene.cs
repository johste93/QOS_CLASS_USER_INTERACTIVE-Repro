using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSecondScene : MonoBehaviour
{
    public string sceneToLoad;

    private bool done;
    private float countDown = 3f;
    
    
    void Update()
    {
        if (done)
            return;

        if (countDown > 0)
            countDown -= Time.deltaTime;
        else
        {
            done = true;
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
