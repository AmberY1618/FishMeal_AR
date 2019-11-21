using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class NavButtonControl : MonoBehaviour
{

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "StartScreen")
        {
            disableAllButtons();
            print("buttons disabled");
            setAllButtonTextWhite();
        }
        print("start method was called"); 
    }

    // Update is called once per frame
    void Update()
    {

        print("The scene name is " + SceneManager.GetActiveScene().name);

        //if in startScreen, reset everything
        //if (SceneManager.GetActiveScene().name == "StartScreen")
        //{
        //    disableAllButtons();
        //    //this.gameObject.SetActive(false);
        //    setAllButtonTextWhite();

        //    print("at start, pulverizeButton is: " + GameObject.Find("PulverizeButton").GetComponent<Button>().IsInteractable());
        //}

        if (SceneManager.GetActiveScene().name == "catch")
        {
            print("we are in catch");
            GameObject.Find("CatchButton").GetComponent<Button>().interactable = true;
            GameObject.Find("Catch_Text").GetComponent<TextMeshProUGUI>().color = new Color(0.962f, 0.431f, 0.431f, 1);
            print("CatchButton is: " + GameObject.Find("CatchButton").GetComponent<Button>().IsInteractable());
            print("pulverizeButton is: " + GameObject.Find("PulverizeButton").GetComponent<Button>().IsInteractable());

        }

        if (SceneManager.GetActiveScene().name == "pulverize")
        {
            print("we are in pulverize");
            GameObject.Find("PulverizeButton").GetComponent<Button>().interactable = true;
            GameObject.Find("Pulverize_Text").GetComponent<TextMeshProUGUI>().color = new Color(0.962f, 0.431f, 0.431f, 1);
            print("in pulverize, CatchButton is: " + GameObject.Find("CatchButton").GetComponent<Button>().IsInteractable());
            print("pulverizeButton is: " + GameObject.Find("PulverizeButton").GetComponent<Button>().IsInteractable());

        }

        if (SceneManager.GetActiveScene().name == "mix")
        {
            print("we are in mix");
            GameObject.Find("MixButton").GetComponent<Button>().interactable = true;
            GameObject.Find("Mix_Text").GetComponent<TextMeshProUGUI>().color = new Color(0.962f, 0.431f, 0.431f, 1);
        }

        if (SceneManager.GetActiveScene().name == "farm")
        {
            print("we are in farm");
            GameObject.Find("FarmButton").GetComponent<Button>().interactable = true;
            GameObject.Find("Farm_Text").GetComponent<TextMeshProUGUI>().color = new Color(0.962f, 0.431f, 0.431f, 1);
        }

        if (SceneManager.GetActiveScene().name == "harvest")
        {
            print("we are in harvest");
            GameObject.Find("HarvestButton").GetComponent<Button>().interactable = true;
            GameObject.Find("Harvest_Text").GetComponent<TextMeshProUGUI>().color = new Color(0.962f, 0.431f, 0.431f, 1);
        }

        if (SceneManager.GetActiveScene().name == "consume")
        {
            print("we are in consume");
            GameObject.Find("ConsumeButton").GetComponent<Button>().interactable = true;
            GameObject.Find("Consume_Text").GetComponent<TextMeshProUGUI>().color = new Color(0.962f, 0.431f, 0.431f, 1);
        }
    }






    public void disableAllButtons()
    {
        GameObject[] navButtons = GameObject.FindGameObjectsWithTag("NavButton");
        foreach(GameObject button in navButtons)
        {
            button.GetComponent<Button>().interactable = false;
        }
    }

    public void setAllButtonTextWhite()
    {
        GameObject[] buttonTextArray = GameObject.FindGameObjectsWithTag("buttonText");
        foreach (GameObject text in buttonTextArray)
        {
            text.GetComponent<TextMeshProUGUI>().color = Color.white;
            
        }
    }
}
