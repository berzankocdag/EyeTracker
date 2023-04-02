using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Tobii.Gaming;

[RequireComponent(typeof(GazeAware))]
public class GazeClick : MonoBehaviour
{
    public GlobalVar globalScript;
    public GameObject button;
	private new Renderer renderer;
    private Color hoverColor = Color.cyan;
    private GazeAware _gazeAware;
    float timeLeft, timeToWait;    
    bool isEnabled = false;

	void Start() {
        _gazeAware = GetComponent<GazeAware>();
        timeToWait = globalScript.waitingTime;
        timeLeft = timeToWait;
        button.GetComponent<Image>().color = Color.white;
	}

    void Update() {
        timeToWait = globalScript.waitingTime;
        if (_gazeAware.HasGazeFocus && !isEnabled) {
            timeLeft -= Time.deltaTime;
            if (timeLeft <= (timeToWait/2)) {
                button.GetComponent<Image>().color = Color.cyan;
            } 
            if (timeLeft <= (timeToWait/4)) {
                button.GetComponent<Image>().color = Color.magenta;
                timeLeft = timeToWait;
                isEnabled = true;
                if (_gazeAware.HasGazeFocus) {
                    Invoke("doClick", timeToWait);
                }
            }
        } 
        else {
            timeLeft = timeToWait;
        }
        if(!_gazeAware.HasGazeFocus) {
            timeLeft = timeToWait;
            isEnabled = false;
            button.GetComponent<Image>().color = Color.white;
        }
    }
    public void doClick() {
        button.GetComponent<Button>().onClick.Invoke();
    }
}
