using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSettings : MonoBehaviour
{
    public GameObject SettingsObject, KeyboardObject, KeyboardButton;

    public void SettingsOpener() {
        bool isActive = KeyboardObject.activeSelf;
        if(isActive){
            KeyboardObject.SetActive(false);
            SettingsObject.SetActive(true);
            KeyboardButton.SetActive(false);

        }
        else{
            KeyboardObject.SetActive(true);
            SettingsObject.SetActive(false);
            KeyboardButton.SetActive(true);
        }
    }
}