//Author: Xiaomeng(Amber) Yuan

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{

    //Button onclick function, set animation active when button is clicked
    public void playAnimation(GameObject animation)
    {
        print("PlayAnimation function called!");
        animation.SetActive(true);
    }

    
}
