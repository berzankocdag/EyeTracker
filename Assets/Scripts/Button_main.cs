using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Button_main : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("Main Scene");
    }
}