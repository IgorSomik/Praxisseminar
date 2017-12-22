using UnityEngine;
using UnityEngine.UI;

public class StoneSceneButtonsController : MonoBehaviour {

    //Public variables
    public GameObject TextOnStoneWall;
    public GameObject LatinTextObject;
    public GameObject GermanTextObject;
    public GameObject ShowHideTextButton;
    public GameObject ShowGerOrLatButton;

    //Private variables
    private bool textDisplayed = false;
    private bool gerTextShown = false;


    //Shows of hides the text on the stone wall
    public void showOrHideText()
    {
        textDisplayed = !textDisplayed;

        if (textDisplayed)
        {
            TextOnStoneWall.SetActive(true);
            ShowHideTextButton.GetComponent<Image>().sprite = Resources.Load<Sprite>("hideText");
        }
        else
        {
            TextOnStoneWall.SetActive(false);
            ShowHideTextButton.GetComponent<Image>().sprite = Resources.Load<Sprite>("showText");
        }
    }


    //Changes the text on the stone wall to latin or german
    public void switchTextToGerOrLat()
    {
        gerTextShown = !gerTextShown;

        if (gerTextShown)
        {
            ShowGerOrLatButton.GetComponent<Image>().sprite = Resources.Load<Sprite>("latText");
            LatinTextObject.SetActive(false);
            GermanTextObject.SetActive(true);
        }
        else
        {
            ShowGerOrLatButton.GetComponent<Image>().sprite = Resources.Load<Sprite>("gerText");
            GermanTextObject.SetActive(false);
            LatinTextObject.SetActive(true);
        }
    }
}
