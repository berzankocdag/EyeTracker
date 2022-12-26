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
            LetterD.SetActive(!isActive);
            LetterE.SetActive(!isActive);
            LetterF.SetActive(!isActive);
            LetterG.SetActive(!isActive);
            LetterH.SetActive(!isActive);
            LetterJ.SetActive(!isActive);
            LetterK.SetActive(!isActive);
            LetterL.SetActive(!isActive);
            LetterM.SetActive(!isActive);
            LetterN.SetActive(!isActive);
            LetterO.SetActive(!isActive);
            LetterP.SetActive(!isActive);
            LetterQ.SetActive(!isActive);
            LetterR.SetActive(!isActive);
            LetterS.SetActive(!isActive);
            LetterT.SetActive(!isActive);
            LetterU.SetActive(!isActive);
            LetterV.SetActive(!isActive);
            LetterW.SetActive(!isActive);
            LetterX.SetActive(!isActive);
            LetterY.SetActive(!isActive);
            LetterZ.SetActive(!isActive);
            DEL.SetActive(!isActive);
        }
    }
}