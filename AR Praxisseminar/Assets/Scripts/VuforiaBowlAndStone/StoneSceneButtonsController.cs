using UnityEngine;
using UnityEngine.UI;

public class StoneSceneButtonsController : MonoBehaviour {

    public GameObject LatinTextObject;
    public GameObject ShowHideTextButton;
    public GameObject ShowGerOrLatButton;

    private bool textDisplayed = false;
    private bool gerTextShown = false;


    public void showOrHideLatinText()
    {
        textDisplayed = !textDisplayed;

        if (textDisplayed)
        {
            LatinTextObject.SetActive(true);
            ShowHideTextButton.GetComponent<Image>().sprite = Resources.Load<Sprite>("hideText");
        }
        else
        {
            LatinTextObject.SetActive(false);
            ShowHideTextButton.GetComponent<Image>().sprite = Resources.Load<Sprite>("showText");
        }
    }


    public void switchTextToGerOrLat()
    {
        gerTextShown = !gerTextShown;

        if (gerTextShown)
        {
            ShowGerOrLatButton.GetComponent<Image>().sprite = Resources.Load<Sprite>("latText");
        }
        else
        {
            ShowGerOrLatButton.GetComponent<Image>().sprite = Resources.Load<Sprite>("gerText");
        }
    }
}
