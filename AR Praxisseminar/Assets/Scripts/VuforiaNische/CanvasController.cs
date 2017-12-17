using System;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    //Public variable
    public GameObject Canves;


    //Enables the canves 
    public void enableCanvas()
    {
        Canves.SetActive(true);
    }


    //Disables the canvas 
    public void disableCanvas()
    {
        Canves.SetActive(false);
    }
}
