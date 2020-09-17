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
        NavigationText.text = BtnText.text;
    }
}
