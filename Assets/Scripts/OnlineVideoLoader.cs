using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using TMPro;

public class OnlineVideoLoader : MonoBehaviour
{
     
    public VideoPlayer videoPlayer;
    public TMP_Text TextField;
    string videoUrl = "http://localhost/videos/";

    // Start is called before the first frame update
    void Start()
    {
        videoUrl += TextField.text + ".mp4";
        Debug.Log(videoUrl);
        videoPlayer.url = videoUrl;
        videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
        videoPlayer.EnableAudioTrack (0, true);
        videoPlayer.Prepare ();
    }
 
    // Update is called once per frame
    void Update()
    {        
    }
}