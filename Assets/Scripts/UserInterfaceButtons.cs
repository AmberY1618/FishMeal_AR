using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInterfaceButtons : MonoBehaviour
{

    public GameObject imageTrackerObj;

    //public void start() {
    //    imageTrackerObj.SetActive(false);
    //}


    public void setTracker()
    {
        imageTrackerObj.SetActive(true);
    }
}
