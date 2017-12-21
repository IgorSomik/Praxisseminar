using UnityEngine;

public class SceneControllerVaseVuforia : MonoBehaviour
{

	//Is loaded when the scene is loaded
	void Start ()
    {
        //Checks if the orientation of the device is on one of the landscapes
        if (Screen.orientation != ScreenOrientation.Landscape)
        {
            Screen.orientation = ScreenOrientation.LandscapeLeft;

            Screen.orientation = ScreenOrientation.AutoRotation;
            Screen.autorotateToPortrait = false;
            Screen.autorotateToPortraitUpsideDown = false;
        }

    }
	
	// Update is called once per frame
	void Update ()
    {
        //Checks if the escape (on mobile device "back) button was clicked abd loads the previous scene
        if (Input.GetKey(KeyCode.Escape))
        {
            loadPreviousScene();
        }
    }

    public void loadPreviousScene()
    {
        LevelManager.LoadLastScene();
    }
}
