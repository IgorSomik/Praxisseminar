using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    static string lastScene;
    static string currentScene;

    //Saves the current scene name
    void Start()
    {
        currentScene = SceneManager.GetActiveScene().name;
    }

    //Prevents teh destruction of the object/script which handles the loading of scenes
    void Awake()
    {
        DontDestroyOnLoad(this.transform.gameObject);
        //Checks if there already is a object which handles the loading of scenes (destroys duplicates)
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
    }

    //Saves the last active scene and loads a new scene with the given scene name
    public static void ChangeScene(string sceneName)
    {
        lastScene = currentScene;
        currentScene = sceneName;
        SceneManager.LoadScene(currentScene);
    }

    //Loads the previously active scene
    public static void LoadLastScene()
    {
        string last = lastScene;
        lastScene = currentScene;
        currentScene = last;
        SceneManager.LoadScene(currentScene);
    }
}
