using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    float duration = 2f;
    private float t = 0;
    bool isReset = false;

    void OnMouseEnter()
    {
        Activate();
    }
    void OnMouseExit()
    {

        Deactivate();

    }
    void Activate()
    {

        GetComponent<Renderer>().material.color = Color.Lerp(Color.white, Color.red, t);
        if (t < 1)
        {
            t += Time.deltaTime / duration;
        }

    }

    void Deactivate()
    {

        GetComponent<Renderer>().material.color = Color.Lerp(Color.red, Color.white, t);
        if (t < 1)
        {
            t += Time.deltaTime / duration;
        }
    }
}