using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    static string lastScene;
    static string currentScene;

    void Start()
    {
        currentScene = SceneManager.GetActiveScene().name;
    }

    void Awake()
    {
        DontDestroyOnLoad(this.transform.gameObject);

        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
    }

    public static void ChangeScene(string sceneName)
    {
        lastScene = currentScene;
        currentScene = sceneName;
        SceneManager.LoadScene(currentScene);
    }

    public static void LoadLastScene()
    {
        string last = lastScene;
        lastScene = currentScene;
        currentScene = last;
        SceneManager.LoadScene(currentScene);
    }
}
