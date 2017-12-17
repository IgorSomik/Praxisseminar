using UnityEngine;

public class SceneControllerExtraContent : MonoBehaviour
{
    //Is called every frame
    void Update()
    {
        //Checks if the escape (on mobile device "back") button was clicked and loads the previous scene
        if (Input.GetKey(KeyCode.Escape))
        {
            loadContentScreen();
        }
    }

    //Loads the vuforia vase scene
    public void loadVaseCameraScene()
    {
        LevelManager.ChangeScene("Vase_Scene_Vuforia");
    }

    //Loads the content scene
    public void loadContentScreen()
    {
        LevelManager.ChangeScene("Vase_Scene_Text");
    }
}
