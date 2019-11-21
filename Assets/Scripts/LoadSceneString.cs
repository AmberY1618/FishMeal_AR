//Author: Xiaomeng(Amber) Yuan
//This script load the scene specified by a given string

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneString : MonoBehaviour
{
    public string sceneName;

    public void NextScene()
    {
        SceneManager.LoadScene(sceneName);
    }

}
