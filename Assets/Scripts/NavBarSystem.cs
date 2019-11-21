//Author: Xiaomeng(Amber) Yuan

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class NavBarSystem : MonoBehaviour
{

    public static HashSet<string> SceneNames;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }


    // Update is called once per frame
    void Update()
    {

        //updating the hash set of scenes visited
        if (SceneManager.GetActiveScene().name == "StartScreen")
        {
            SceneNames = new HashSet<string>();
        }

        if (SceneManager.GetActiveScene().name == "catch")
        {
            SceneNames.Add("catch");
        }

        if (SceneManager.GetActiveScene().name == "pulverize")
        {
            SceneNames.Add("pulverize");
        }

        if (SceneManager.GetActiveScene().name == "mix")
        {
            SceneNames.Add("mix");
        }

        if (SceneManager.GetActiveScene().name == "farm")
        {
            SceneNames.Add("farm");
        }

        if (SceneManager.GetActiveScene().name == "harvest")
        {
            SceneNames.Add("harvest");
        }

        if (SceneManager.GetActiveScene().name == "consume")
        {
            SceneNames.Add("consume");
        }




        //update the navigation buttons according to the scenes visited
        if (SceneNames.Contains("catch"))
        {
            GameObject.Find("CatchButton").GetComponent<Button>().interactable = true;
            GameObject.Find("Catch_Text").GetComponent<TextMeshProUGUI>().color = new Color(0.962f, 0.431f, 0.431f, 1);
        } else
        {
            GameObject.Find("CatchButton").GetComponent<Button>().interactable = false;

        }

        if (SceneNames.Contains("pulverize"))
        {
            GameObject.Find("PulverizeButton").GetComponent<Button>().interactable = true;
            GameObject.Find("Pulverize_Text").GetComponent<TextMeshProUGUI>().color = new Color(0.962f, 0.431f, 0.431f, 1);
        } else
        {
            GameObject.Find("PulverizeButton").GetComponent<Button>().interactable = false;
        }

        if (SceneNames.Contains("mix"))
        {
            GameObject.Find("MixButton").GetComponent<Button>().interactable = true;
            GameObject.Find("Mix_Text").GetComponent<TextMeshProUGUI>().color = new Color(0.962f, 0.431f, 0.431f, 1);
        } else
        {
            GameObject.Find("MixButton").GetComponent<Button>().interactable = false;
        }

        if (SceneNames.Contains("farm"))
        {
            GameObject.Find("FarmButton").GetComponent<Button>().interactable = true;
            GameObject.Find("Farm_Text").GetComponent<TextMeshProUGUI>().color = new Color(0.962f, 0.431f, 0.431f, 1);
        } else
        {
            GameObject.Find("FarmButton").GetComponent<Button>().interactable = false;
        }

        if (SceneNames.Contains("harvest"))
        {
            GameObject.Find("HarvestButton").GetComponent<Button>().interactable = true;
            GameObject.Find("Harvest_Text").GetComponent<TextMeshProUGUI>().color = new Color(0.962f, 0.431f, 0.431f, 1);
        } else
        {
            GameObject.Find("HarvestButton").GetComponent<Button>().interactable = false;
        }

        if (SceneNames.Contains("consume"))
        {
            GameObject.Find("ConsumeButton").GetComponent<Button>().interactable = true;
            GameObject.Find("Consume_Text").GetComponent<TextMeshProUGUI>().color = new Color(0.962f, 0.431f, 0.431f, 1);
        } else
        {
            GameObject.Find("ConsumeButton").GetComponent<Button>().interactable = false;
        }

    }
}
