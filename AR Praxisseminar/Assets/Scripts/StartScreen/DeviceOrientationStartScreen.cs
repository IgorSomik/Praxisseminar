using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeviceOrientationStartScreen : MonoBehaviour {

    void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;        
    }

    // Update is called once per frame
    void Update () {
        if(Screen.orientation != ScreenOrientation.Portrait)
        {
            Screen.orientation = ScreenOrientation.Portrait;
        }
    }
}
