using UnityEngine;

public class ClickHandler : MonoBehaviour
{
    //Private variables
    private UIController UIController;

    //Loads the controller of the scene
    private void Start()
    {
        UIController = GameObject.FindGameObjectWithTag("Controller").GetComponent<UIController>();
    }
    
    //Sets a click listener and sends the clicked objects
    private void OnMouseDown()
    {
        UIController.clickOnParticle(gameObject.transform.parent.gameObject);
    }
}
