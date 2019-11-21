using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoProgressAndSkip : MonoBehaviour
{

    public Slider progressBar;
    public VideoPlayer videoPlayer;
    public Text skipText;
    //public Button skipButton;

    // Start is called before the first frame update
    void Start()
    {
        //skipText = GameObject.Find("skipText").GetComponent<Text>();
        //progressBar = GameObject.Find("Slider").GetComponent<Slider>();


        progressBar.gameObject.SetActive(false);
        //skipButton.gameObject.SetActive(false);
        videoPlayer.Prepare();
        videoPlayer.Stop();

    }

    // Update is called once per frame
    void Update()
    {

        if (DefaultTrackableEventHandler.Detected)
        {
            
            progressBar.gameObject.SetActive(true);
            //skipButton.gameObject.SetActive(true);
            videoPlayer.Play();
            progressBar.value = ((float)videoPlayer.frame / (float)videoPlayer.frameCount);
            skipText.text = (int)(videoPlayer.length * (1 - progressBar.value)) + "s Skip";

        } else
        {
            videoPlayer.Pause();
        }
    }
}
