using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour {

    public GameObject Canves;
    public GameObject TextCrane;
    public GameObject TextBowl;
    public GameObject TextHandle;

    public GameObject Vase;

    private GameObject[] clickables;
    private bool textCurrentlyShown = false;
    private GameObject displayedText;
    private GameObject clickedSelectable;


    private void Start()
    {
        clickables = GameObject.FindGameObjectsWithTag("Clickables");
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
            //Canves.SetActive(true);
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
        }
        else if(name == "ParticleBowl")
        {
            displayedText = TextBowl;
        }
        else
        {
            displayedText = TextHandle;
        }
        displayedText.SetActive(true);
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

        clickedSelectable = null;
        textCurrentlyShown = false;
        displayedText.SetActive(false);
        //Canves.SetActive(false);
    }
}
