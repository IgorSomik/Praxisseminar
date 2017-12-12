using UnityEngine;

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
        LevelManager.ChangeScene("Vase_Scene_Vuforia");
    }

    public void loadExtraContentScreen()
    {
        LevelManager.ChangeScene("Vase_Scene_Text_Extra");
    }

    public void loadStartScreen()
    {
        LevelManager.ChangeScene("StartScreen");
    }
}
