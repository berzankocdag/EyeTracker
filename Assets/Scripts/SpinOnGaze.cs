// Example script on Gaze Aware object:
// Make object spin when looked at!

using Tobii.Gaming;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(GazeAware))]
public class SpinOnGaze : MonoBehaviour
{
    private GazeAware _gazeAware;
    public GameObject button;

    void Start()
    {
        _gazeAware = GetComponent<GazeAware>();
    }
 
    void Update()
    {
        if (_gazeAware.HasGazeFocus)
        {
            Debug.Log("has focus");
            button.GetComponent<Image>().color = Color.red;
        }
    }
}