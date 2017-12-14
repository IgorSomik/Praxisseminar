using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour {

    public GameObject Canves;
    public GameObject TextCrane;
    public GameObject TextBowl;
    public GameObject TextHandle;
    public GameObject EwerCap;
    public GameObject WaterInPod;
    public GameObject WaterInBowl;
    public GameObject WaterFlow;
    public GameObject WaterSurfaceCrane;

    public GameObject Vase;

    private GameObject[] clickables;
    private bool textCurrentlyShown = false;
    private bool handleClicked = false;
    private bool craneClicke = false;
    private bool bowlClicked = false;
    private GameObject displayedText;
    private GameObject clickedSelectable;
    private Vector3 startPositionCap;
    private Vector3 startPositionWaterCrane;
    private Vector3 startPositionWaterBowl;


    private void Start()
    {
        clickables = GameObject.FindGameObjectsWithTag("Clickables");
        startPositionCap = EwerCap.transform.position;
        startPositionWaterCrane = WaterSurfaceCrane.transform.position;
        startPositionWaterBowl = WaterInBowl.transform.position;
    }

    private void Update()
    {
        if (handleClicked)
        {
            if(EwerCap.transform.position.y < 8.5f)
            {
                EwerCap.transform.position += new Vector3(0, 0.05f, 0);
            }
        }

        if (craneClicke)
        {
            if(WaterSurfaceCrane.transform.position.y < 2.25f)
            {
                WaterSurfaceCrane.transform.position += new Vector3(0, 0.005f, 0);
            }
        }

        if (bowlClicked)
        {
            if(WaterInBowl.transform.position.y < 2.6f)
            {
                WaterInBowl.transform.position += new Vector3(0, 0.005f, 0);
            }
        }
    }

    public void clickOnParticle(GameObject clickedObject)
    {
        clickedSelectable = clickedObject;
        if (!textCurrentlyShown)
        {
            for(int i = 0; i < clickables.Length; i++)
            {
                if(clickables[i] != clickedObject)
                {
                    clickables[i].SetActive(false);
                }
            }
            activateTextForClickedObject(clickedObject.name);
            textCurrentlyShown = true;
        }
        else
        {
            showAllClickables();
        }
    }

    private void activateTextForClickedObject(string name)
    {
        if(name == "ParticleCrane")
        {
            displayedText = TextCrane;
            WaterFlow.SetActive(true);
            Invoke("showWaterInBowl", 0.7f);
        }
        else if(name == "ParticleBowl")
        {
            displayedText = TextBowl;
            WaterInBowl.SetActive(true);
            bowlClicked = true;
        }
        else
        {
            displayedText = TextHandle;
            handleClicked = true;
            WaterInPod.SetActive(true);
        }
        displayedText.SetActive(true);
    }

    private void showWaterInBowl()
    {
        craneClicke = true;
    }

    public void showAllClickables()
    {
        for(int i = 0; i < clickables.Length; i++)
        {
            if(clickables[i] != clickedSelectable)
            {
                clickables[i].SetActive(true);
            }
        }

        if (WaterFlow.activeInHierarchy)
        {
            WaterFlow.SetActive(false);
        }

        if (handleClicked)
        {
            handleClicked = false;
            EwerCap.transform.position = startPositionCap;
            WaterInPod.SetActive(false);
        }

        if (craneClicke)
        {
            craneClicke = false;
            WaterSurfaceCrane.transform.position = startPositionWaterCrane;
        }

        if (bowlClicked)
        {
            WaterInBowl.SetActive(false);
            bowlClicked = false;
            WaterInBowl.transform.position = startPositionWaterBowl;
        }
        clickedSelectable = null;
        textCurrentlyShown = false;
        displayedText.SetActive(false);
    }
}
