using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
	private Color hoverColor = Color.green;
	private Renderer renderer;
    bool isHovering = false;
    public float timeToWait = 3;
    float timeLeft;    

	void Start() {
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
        if (isHovering) {
            timeLeft -= Time.deltaTime;
        }
        if (timeLeft <= 0) {
            renderer.material.color = hoverColor;
        } 
    }
}
