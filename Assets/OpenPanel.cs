using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPanel : MonoBehaviour
{
    public GameObject Panel, InputField, LetterA, LetterB, LetterC, DEL;

    public void PanelOpener() {
        if (Panel != null) {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
            InputField.SetActive(!isActive);
            LetterA.SetActive(!isActive);
            LetterB.SetActive(!isActive);
            LetterC.SetActive(!isActive);
            DEL.SetActive(!isActive);
        }
    }
}