using UnityEngine;

public class DeviceOrientationStartScreen : MonoBehaviour {

    //Sets the orientation of the device to the portrait view
    void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;        
    }

    // Update is called once per frame
    void Update () {
        //Checks the orientation of the device and sets the orientation to portrait if necessary
        if (Screen.orientation != ScreenOrientation.Portrait)
        {
            Screen.orientation = ScreenOrientation.Portrait;
        }
    }
}
