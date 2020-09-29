using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCanvas : MonoBehaviour
{
    public GameObject canvas;
    public GameObject cube;

    private float angle = 360;
    private bool condition = false;
    private bool secondCondition = false;
    
    void Start()
    {
        angle = 360;
    }

    void Update()
    {
        float rotY = Camera.main.transform.eulerAngles.y;
        if (Math.Abs(angle - rotY) > 35 && condition == false && rotY > 35 && secondCondition == false)
        {
            condition = true;
            secondCondition = true;
            canvas.transform.position = cube.transform.position;
            canvas.transform.rotation = cube.transform.rotation;
            angle = rotY;
            condition = false;
        }
        else if(Math.Abs(angle - rotY) > 35 && condition == false && secondCondition == true)
        {
            condition = true;
            canvas.transform.position = cube.transform.position;
            canvas.transform.rotation = cube.transform.rotation;
            angle = rotY;
            condition = false;
        }
    }
}
