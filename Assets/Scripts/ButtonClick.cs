using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonClick : MonoBehaviour
{
    public TMP_Text TextField;
    public GlobalVar globalScript;
    public GameObject VideoSystem;


    void Start() {
        if (TextField.text == "Please Give an Input") {
            TextField.text = "";
        }
    }

    public void SetText(string text) {
        if (text == "DEL") {
            if(TextField.text.Length != 0 && TextField.text != "Please Give an Input") {
                TextField.text = TextField.text.Remove(TextField.text.Length - 1);
            } 
            else {
                TextField.text = "Please Give an Input";
            }
        }
        else if (text == "Increase") {
            globalScript.waitingTime += 1;
        }
        else if (text == "Decrease") {
            globalScript.waitingTime -= 1;
        }
        else if (text == "VIDEO" && TextField.text.Length >= 0) {
            bool isActive = VideoSystem.activeSelf;
            VideoSystem.SetActive(!isActive);
        }
        else if (text != "DEL" && TextField.text.Length >= 0) {
            if(TextField.text == "Please Give an Input") {
                TextField.text = text;
            }
            else {
                TextField.text = TextField.text + text;
            }
        }
    }
}
