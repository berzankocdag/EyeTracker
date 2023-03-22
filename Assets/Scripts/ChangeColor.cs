using System.Collections;
using System.Collections.Generic;
using Tobii.Gaming;
using UnityEngine;
 

[RequireComponent(typeof(GazeAware))]
public class ChangeColor : MonoBehaviour
{
	private Color hoverColor = Color.cyan;
	private Renderer renderer;
    bool isHovering = false;
    public float timeToWait = 3;
    float timeLeft;    

    private GazeAware _gazeAware;

	void Start() {
        _gazeAware = GetComponent<GazeAware>();
        Debug.Log("started");
		renderer = GetComponent<Renderer>();
		renderer.material.color = Color.white;
        timeLeft = timeToWait;
	}
 
	void OnMouseOver() {
        isHovering = true;
    }
 
	void OnMouseExit() {
		isHovering = false;
        timeLeft = timeToWait;
        renderer.material.color = Color.white;
    }

    void Update() {
        if (_gazeAware.HasGazeFocus) {
            Debug.Log("FOCUS");
            timeLeft -= Time.deltaTime;
        }
        if (timeLeft <= 0) {
            renderer.material.color = hoverColor;            
        }
    }
}