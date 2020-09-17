using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateCircle : MonoBehaviour
{
    public GameObject OuterMainMenuReplacement;
    public GameObject middleMenuReplacement;
    public GameObject InnerMenuReplacement;
    public GameObject circle;
    public void Activate()
    {
        OuterMainMenuReplacement.SetActive(true);
        middleMenuReplacement.SetActive(true);
        InnerMenuReplacement.SetActive(true);
        circle.SetActive(true);
    }
}
