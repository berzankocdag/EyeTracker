using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPanel : MonoBehaviour
{
    public GameObject InputField, KeyboardObject;

    public void PanelOpener() {
        if (InputField != null) {
            bool isActive = InputField.activeSelf;
            InputField.SetActive(!isActive);
            KeyboardObject.SetActive(!isActive);
        }
    }
}