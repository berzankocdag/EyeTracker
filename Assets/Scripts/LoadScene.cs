using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadScene : MonoBehaviour
{
    public void LoadExploreScene()
    {
        SceneManager.LoadScene("Explore");
    }

    public void LoadFoodScene()
    {
        SceneManager.LoadScene("Scene_food");
    }
    public void LoadHouseWorksScene()
    {
        SceneManager.LoadScene("HouseWorks");
    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene("Main Scene");
    }

    public void LoadShowerScene()
    {
        SceneManager.LoadScene("Shower");
    }









}
