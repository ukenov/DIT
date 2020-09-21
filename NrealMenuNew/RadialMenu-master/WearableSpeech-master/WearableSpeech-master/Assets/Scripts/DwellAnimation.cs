using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DwellAnimation : MonoBehaviour
{
    public GameObject circleHover;
    public GameObject circleImage;
    void Update()
    {
        circleImage.transform.position = circleHover.transform.position;
    }
}
