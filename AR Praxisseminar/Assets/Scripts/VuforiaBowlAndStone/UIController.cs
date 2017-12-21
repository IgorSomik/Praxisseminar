using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    //Public variables
    public GameObject InformationTextArea;
    public Text HeaderInfoArea;
    public Text ContentInfoArea;
    public GameObject ShowHideContentButton;
    public GameObject AllContendOnScreen;
    public GameObject EwerCap;
    public GameObject WaterInPod;
    public GameObject WaterFlow;
    public GameObject WaterSurfaceCrane;
    public GameObject WaterInBowl;

    //private variables
    private GameObject[] clickables;

    private bool textCurrentlyShown = false;
    private bool handleClicked = false;
    private bool craneClicked = false;
    private bool bowlClicked = false;
    private bool showHideButtonClicked = false;

    private GameObject clickedSelectable;

    private Vector3 startPositionCap;
    private Vector3 startPositionWaterCrane;
    private Vector3 startPositionWaterBowl;


    //Called when the scene is loaded. Gets all clickables and all start positions of the objects which will be moved later
    private void Start()
    {
        clickables = GameObject.FindGameObjectsWithTag("Clickables");
        startPositionCap = EwerCap.transform.position;
        startPositionWaterCrane = WaterSurfaceCrane.transform.position;
        startPositionWaterBowl = WaterInBowl.transform.position;
    }

    //This function is called every frame
    private void Update()
    {
        isHandleSelected();
        isCraneSelected();
        isBowlSelected();
    }


    //Checks if the bowl was selected by the user and rauses the water in the bowl
    private void isBowlSelected()
    {
        if (bowlClicked)
        {
            if (WaterInBowl.transform.position.y < startPositionWaterBowl.y + 0.51f)
            {
                WaterInBowl.transform.position += new Vector3(0, 0.005f, 0);
            }
        }
    }


    //Checks if the crane was selected by the user and raises the water in the bowl
    private void isCraneSelected()
    {
        if (craneClicked)
        {
            if (WaterSurfaceCrane.transform.position.y < startPositionWaterCrane.y + 0.16f)
            {
                WaterSurfaceCrane.transform.position += new Vector3(0, 0.005f, 0);
            }
        }
    }


    //Checks if the handle was selected by the user and raises the cap of the ewer
    private void isHandleSelected()
    {
        if (handleClicked)
        {
            if (EwerCap.transform.position.y < startPositionCap.y + 0.9f)
            {
                EwerCap.transform.position += new Vector3(0, 0.05f, 0);
            }
        }
    }


    //Checks which object was selected by the user and depending on the case hides the non selected objects or shows all selectable objects again
    public void clickOnParticle(GameObject clickedObject)
    {
        //Checks if information text is currently shown
        if (!textCurrentlyShown)
        {
            for(int i = 0; i < clickables.Length; i++)
            {
                if(clickables[i] != clickedObject)
                {
                    clickables[i].SetActive(false);
                }
            }
            clickedSelectable = clickedObject;
            showInformationOnScreen(clickedObject.name);
            textCurrentlyShown = true;
        }
        else
        {
            showAllClickables();
        }
    }


    //Displays the information for the clicked object
    private void showInformationOnScreen(string name)
    {
        string textHeader = "";
        string textContent = "";

        if(name == "ParticleHandle")
        {
            textHeader = "Kesselgriff";
            textContent = "Der Kessel wurde in der Lavabo-Nische aufgehängt und stehts mit frischem Wasser befüllt.";
            raiseEwerCap();
        }
        else if (name == "ParticleCrane")
        {
            textHeader = "Wasserhahn";
            textContent = "Die Mönche haben sich nach der Arbeit die Hände mit sauberem Wasser aus dem Kessel gewaschen.";
            enableWaterFlow();
        }
        else
        {
            textHeader = "Wasserschüssel";
            textContent = "Eine Schüssel wurde unter den Kessel gestellt um das fließende Wasser aus dem Wasserhahn aufzufangen.";
            displayWaterInBowl();
        }
        HeaderInfoArea.text = textHeader;
        ContentInfoArea.text = textContent;

        InformationTextArea.SetActive(true);
    }


    //Shows the water in the bowl
    private void displayWaterInBowl()
    {
        WaterInBowl.SetActive(true);
        bowlClicked = true;
    }


    //Shows the waterflow from the crane and displays the water in the bowl
    private void enableWaterFlow()
    {
        WaterFlow.SetActive(true);
        Invoke("showWaterInBowl", 0.7f);
    }


    //Shows the water in the bowl after a short delay
    private void showWaterInBowl()
    {
        craneClicked = true;
    }


    //Raises the ewer cap and shows the water inside
    private void raiseEwerCap()
    {
        handleClicked = true;
        WaterInPod.SetActive(true);
    }


    //Shows all highlights of the clickable objects
    public void showAllClickables()
    {
        for(int i = 0; i < clickables.Length; i++)
        {
            if(clickables[i] != clickedSelectable)
            {
                clickables[i].SetActive(true);
            }
        }
        resetAllOjects();
        clickedSelectable = null;
        textCurrentlyShown = false;

        InformationTextArea.SetActive(false);
    }


    //Checks which object was clicked and resets the object and the animation to the original state
    private void resetAllOjects()
    {
        if (handleClicked)
        {
            WaterInPod.SetActive(false);
            handleClicked = false;
            EwerCap.transform.position = startPositionCap;
        }

        if (craneClicked)
        {
            WaterFlow.SetActive(false);
            craneClicked = false;
            WaterSurfaceCrane.transform.position = startPositionWaterCrane;
        }

        if (bowlClicked)
        {
            WaterInBowl.SetActive(false);
            bowlClicked = false;
            WaterInBowl.transform.position = startPositionWaterBowl;
        }
    }


    //Checks if the show or hide button was clicked and shwos or hides the content on the screen
    public void showOrHideContentOnScreen()
    {
        showHideButtonClicked = !showHideButtonClicked;

        if (showHideButtonClicked)
        {
            AllContendOnScreen.SetActive(false);
            ShowHideContentButton.GetComponent<Image>().sprite = Resources.Load<Sprite>("show");
        }
        else
        {
            AllContendOnScreen.SetActive(true);
            ShowHideContentButton.GetComponent<Image>().sprite = Resources.Load<Sprite>("hide");

        }
    }
}
