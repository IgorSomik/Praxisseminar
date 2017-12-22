using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasController : MonoBehaviour
{
    //Public variable
    public GameObject Canves;

    //Private variable
    private GameObject[] stonewalls;

    //Called when the scene is started
    private void Start()
    {
        //Checks if the current scene is the stone wall scene and if so then the left and right stone wall will be disabled
        if(SceneManager.GetActiveScene().name == "stone_scene_vuforia")
        {
            stonewalls = GameObject.FindGameObjectsWithTag("Stonewall");

            for (int i = 0; i < stonewalls.Length; i++)
            {
                stonewalls[i].SetActive(false);
            }

        }
    }


    //Enables the canves or stone walls (depending on the scene)
    public void enableCanvas()
    {
        if (SceneManager.GetActiveScene().name == "Vase_Scene_Vuforia" && Canves.activeSelf == false)
        {
            Canves.SetActive(true);
        }

        if(SceneManager.GetActiveScene().name == "stone_scene_vuforia")
        {
            for(int i = 0; i < stonewalls.Length; i++)
            {
                stonewalls[i].SetActive(true);
            }
        }
    }


    //Disables the canvas in the vase scene
    public void disableCanvas()
    {
        if (Canves != null && SceneManager.GetActiveScene().name == "Vase_Scene_Vuforia" && Canves.activeSelf == true)
        {
            Canves.SetActive(false);
        }
    }
}
