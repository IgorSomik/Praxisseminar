using UnityEngine;

public class ControllerStartScreen : MonoBehaviour {

    void Update()
    {
        if (Input.GetKey("escape"))
            Application.Quit();
    }

    public void loadStonePanelScene()
    {
        LevelManager.ChangeScene("Vase_Scene_Vuforia");
    }

    public void loadVaseInformationScene()
    {
        LevelManager.ChangeScene("Vase_Scene_Text");
    }

    public void quitApplication()
    {
        Application.Quit();
    }
}
