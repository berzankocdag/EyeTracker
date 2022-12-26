using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPanel : MonoBehaviour
{
    public GameObject Square1, Square2, InputField, LetterA, LetterB, LetterC, LetterD, DEL;

    public void PanelOpener() {
        if (InputField != null) {
            bool isActive = InputField.activeSelf;
            InputField.SetActive(!isActive);
            LetterA.SetActive(!isActive);
            LetterB.SetActive(!isActive);
            LetterC.SetActive(!isActive);
            LetterD.SetActive(!isActive);
            Square1.SetActive(isActive);
            Square2.SetActive(isActive);
            DEL.SetActive(!isActive);
        }
    }
}