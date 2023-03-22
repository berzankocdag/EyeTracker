using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonClick : MonoBehaviour
{
    public TMP_Text TextField;

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
        else if (TextField.text != "DEL" && TextField.text.Length >= 0) {
            if(TextField.text == "Please Give an Input") {
                TextField.text = text;
            }
            else {
                TextField.text = TextField.text + text;
            }
        }
        // else if (TextField.text == "Left") {
                
        // }
        // else if (TextField.text == "Right") {

        // }
    }
}
