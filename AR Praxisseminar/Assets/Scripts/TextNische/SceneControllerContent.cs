using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControllerContent : MonoBehaviour {

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            loadStartScreen();
        }
    }

    public void loadVaseCameraScene()
    {
        SceneManager.LoadScene(2);
        SceneManager.UnloadSceneAsync(1);
    }

    public void loadStartScreen()
    {
        SceneManager.LoadScene(0);
        SceneManager.UnloadSceneAsync(1);
    }
}
