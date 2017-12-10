using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHandler : MonoBehaviour {

    private UIController UIController;


    private void Start()
    {
        UIController = GameObject.FindGameObjectWithTag("Controller").GetComponent<UIController>();
    }

    private void OnMouseDown()
    {
        UIController.clickOnParticle(gameObject.transform.parent.gameObject);
    }
}
