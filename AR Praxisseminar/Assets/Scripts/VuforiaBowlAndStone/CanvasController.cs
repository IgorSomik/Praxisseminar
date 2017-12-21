using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasController : MonoBehaviour
{
    //Public variable
    public GameObject Canves;


    //Enables the canves 
    public void enableCanvas()
    {
        if (SceneManager.GetActiveScene().name == "Vase_Scene_Vuforia" && Canves.activeSelf == false)
        {
            Canves.SetActive(true);
        }
    }


    //Disables the canvas 
    public void disableCanvas()
    {
        if (SceneManager.GetActiveScene().name == "Vase_Scene_Vuforia" && Canves.activeSelf == true)
        {
            Canves.SetActive(false);
        }
    }
}
