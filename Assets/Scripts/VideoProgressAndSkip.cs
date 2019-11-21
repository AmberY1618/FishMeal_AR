//Author: Xiaomeng(Amber) Yuan
//This script controls the slider that shows the video player progress and the skip button

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

    // Start is called before the first frame update
    void Start()
    {
        //set slider inactive at the beginning, prepare the video
        progressBar.gameObject.SetActive(false);
        videoPlayer.Prepare();
        videoPlayer.Stop();

    }

    // Update is called once per frame
    void Update()
    {
        //if the image target is detected, play the video and update the slider
        //if the image target is not detected, pause the video
        if (DefaultTrackableEventHandler.Detected)
        {
            
            progressBar.gameObject.SetActive(true);
            videoPlayer.Play();
            progressBar.value = ((float)videoPlayer.frame / (float)videoPlayer.frameCount);
            skipText.text = (int)(videoPlayer.length * (1 - progressBar.value)) + "s Skip";

        } else
        {
            videoPlayer.Pause();
        }
    }
}
