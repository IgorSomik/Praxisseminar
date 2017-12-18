using System;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    //Public variable
    public GameObject Canves;


    //Enables the canves 
    public void enableCanvas()
    {
        if(Canves.activeSelf == false)
        {
            Canves.SetActive(true);
        }
    }


    //Disables the canvas 
    public void disableCanvas()
    {
        if (Canves.activeSelf == true)
        {
            Canves.SetActive(false);
        }
    }
}
