using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GlobalVar : MonoBehaviour
{
    public float waitingTime = 3; 
    public TMP_Text TextField;
    // Start is called before the first frame update

    public void IncreaseTime() {
      waitingTime += 1;
    }

    public void DecreaseTime() {
      waitingTime -= 1;
    }

    public void SetNumber(string text) {
      Debug.Log("ZOR");

      if (text == "-") {
        DecreaseTime();
      }
      else {
        IncreaseTime();
      }
    }
}
