using UnityEngine;

public class SceneControllerExtraContent : MonoBehaviour {

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            loadContentScreen();
        }
    }

    public void loadVaseCameraScene()
    {
        LevelManager.ChangeScene("Vase_Scene_Vuforia");
    }

    public void loadContentScreen()
    {
        LevelManager.ChangeScene("Vase_Scene_Text");
    }
}
