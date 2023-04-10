using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Button_explore : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("Explore");
    }
}
