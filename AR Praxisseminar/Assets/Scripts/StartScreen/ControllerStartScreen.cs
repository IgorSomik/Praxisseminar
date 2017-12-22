using UnityEngine;

public class ControllerStartScreen : MonoBehaviour {

    //Checks every frame if the escape button (on mobile the back button) was clicked
    void Update()
    {
        //If escape (on mobile back) button was clicked the application will be closed
        if (Input.GetKey("escape"))
            Application.Quit();
    }

    //Loads the scene with the stone panel target
    public void loadStonePanelScene()
    {
        LevelManager.ChangeScene("stone_scene_vuforia");
    }

    //Loads the scene with the vase target
    public void loadVaseInformationScene()
    {
        LevelManager.ChangeScene("Vase_Scene_Text");
    }

    //Quits the application
    public void quitApplication()
    {
        Application.Quit();
    }
}
