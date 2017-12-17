using UnityEngine;

public class SceneControllerContent : MonoBehaviour
{
    //Is loaded every frame
    void Update()
    {
        //Checks if the escape (on mobile device "back") button was clicked and loads the previously active scene
        if (Input.GetKey(KeyCode.Escape))
        {
            loadStartScreen();
        }
    }

    //Loads the vuforia vase scene
    public void loadVaseCameraScene()
    {
        LevelManager.ChangeScene("Vase_Scene_Vuforia");
    }

    //Loads the extra content scene
    public void loadExtraContentScreen()
    {
        LevelManager.ChangeScene("Vase_Scene_Text_Extra");
    }

    //Loads the start scene
    public void loadStartScreen()
    {
        LevelManager.ChangeScene("StartScreen");
    }
}
