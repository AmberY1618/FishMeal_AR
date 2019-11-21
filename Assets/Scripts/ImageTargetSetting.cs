using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ImageTargetSetting : MonoBehaviour
{
    public Button button;

    // Start is called before the first frame update
    void Start()
    {

        this.gameObject.SetActive(false);

        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }


    void TaskOnClick()
    {

        print(this.gameObject.name);
        print("button pressed!");
        this.gameObject.SetActive(true);
    }
}
