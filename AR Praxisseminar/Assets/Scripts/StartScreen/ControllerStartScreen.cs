using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerStartScreen : MonoBehaviour {

    void Update()
    {
        if (Input.GetKey("escape"))
            Application.Quit();

    }

    public void loadVaseInformationScene()
    {
        SceneManager.LoadScene(1);
        SceneManager.UnloadSceneAsync(0);
    }

    public void quitApplication()
    {
        Application.Quit();
    }
}
