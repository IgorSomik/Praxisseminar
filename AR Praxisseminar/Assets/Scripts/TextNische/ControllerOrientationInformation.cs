using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerOrientationInformation : MonoBehaviour
{
    //Sets the orientation of the device to portrait when the scene is loaded
    void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;
    }

    // Update is called once per frame
    void Update()
    {
        //Checks if the orientation of the device is portrait and changes the orientation if necessery
        if (Screen.orientation != ScreenOrientation.Portrait)
        {
            Screen.orientation = ScreenOrientation.Portrait;
        }
    }
}
