using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonClick : MonoBehaviour
{
    public TMP_Text Textfield;

    void Start() {
        if (Textfield.text == "Please Give an Input") {
            Textfield.text = "";
        }
    }

    public void SetText(string text) {    
        if (text == "DEL" && Textfield.text.Length != 0) {
            Textfield.text = Textfield.text.Remove(Textfield.text.Length - 1);
        }
        else if (Textfield.text != "DEL" && Textfield.text.Length >= 0) {
            Textfield.text = Textfield.text + text;
        }
    }
}
