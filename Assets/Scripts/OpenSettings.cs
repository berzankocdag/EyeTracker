using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSettings : MonoBehaviour
{
    public GameObject SettingsObject, VideoObject, KeyboardObject;

    public void SettingsOpener() {
        bool isActive = SettingsObject.activeSelf;
        if(isActive){
            SettingsObject.SetActive(false);
        }
        else{
            SettingsObject.SetActive(true);
        }
    }
    public void VideoBack() {
        VideoObject.SetActive(false);
    }
}