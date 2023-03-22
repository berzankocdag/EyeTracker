using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Tobii.Gaming;

[RequireComponent(typeof(GazeAware))]
public class GazeClick : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GlobalVar globalScript;
    public GameObject button;
	private new Renderer renderer;
    private Color hoverColor = Color.cyan;
    
    private GazeAware _gazeAware;

    bool isHovering = false;
    float timeLeft, timeToWait;    

	void Start() {
        _gazeAware = GetComponent<GazeAware>();
        timeToWait = globalScript.waitingTime;
        timeLeft = timeToWait;
        button.GetComponent<Image>().color = Color.white;
	}

    void Update() {
        if(_gazeAware.HasGazeFocus || isHovering) {
            timeLeft -= Time.deltaTime;
        }
        if (timeLeft <= (timeToWait/2)) {
            button.GetComponent<Image>().color = Color.cyan;
        }
        if (timeLeft <= (timeToWait/4)) {
            button.GetComponent<Image>().color = Color.magenta;
        }  
    }

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        Invoke("doClick", timeToWait);
        isHovering = true;
    }

    public void OnPointerExit(PointerEventData pointerEventData)
    {
        CancelInvoke("doClick");
        isHovering = false;
        timeLeft = timeToWait;
        button.GetComponent<Image>().color = Color.white;
    }

    public void doClick() {
        GetComponent<Button>().onClick.Invoke();
    }
}
