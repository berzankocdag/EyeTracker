using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveKeyboard : MonoBehaviour
{
    public GameObject KeyboardObject;
    Vector3 tempPosition;

    public void upMove() {
        tempPosition = KeyboardObject.transform.position;
        tempPosition.y += 10f;
        KeyboardObject.transform.position = tempPosition;     
    }

    public void downMove() {
        tempPosition = KeyboardObject.transform.position;
        tempPosition.y -= 10f;
        KeyboardObject.transform.position = tempPosition;     
    }

    public void leftMove() {
        tempPosition = KeyboardObject.transform.position;
        tempPosition.x -= 10f;
        KeyboardObject.transform.position = tempPosition;     
    }

    public void rightMove() {
        tempPosition = KeyboardObject.transform.position;
        tempPosition.x += 10f;
        KeyboardObject.transform.position = tempPosition;     
    }

}