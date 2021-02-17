using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Joystick moveStick;
    public float xAxis;
    public float zAxis;

    public bool isPressedMoveStick;
    private void Update()
    {
        xAxis = moveStick.Horizontal;
        zAxis = moveStick.Vertical;
        isPressedMoveStick = moveStick.IsTouched;
    }
}
