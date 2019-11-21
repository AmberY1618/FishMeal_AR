using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{

    //public GameObject animation;

    public void playAnimation(GameObject animation)
    {
        print("PlayAnimation function called!");
        animation.SetActive(true);
    }

    
}
