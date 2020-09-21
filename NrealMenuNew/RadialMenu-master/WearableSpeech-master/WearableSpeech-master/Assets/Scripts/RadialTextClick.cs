using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RadialTextClick : MonoBehaviour
{
    public TMP_InputField NavigationText;
    public Text BtnText;
    
    public void FillTextField()
    {
        if (BtnText.text.Contains("\n"))
            NavigationText.text = BtnText.text.Replace("\n", " ");
        else
        {
            NavigationText.text = BtnText.text;
        }
    }
}
