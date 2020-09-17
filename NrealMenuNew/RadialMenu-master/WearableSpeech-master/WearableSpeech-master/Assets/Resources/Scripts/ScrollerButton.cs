using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// http://gregandaduck.blogspot.com/2015/07/unity-ui-dynamic-buttons-and-scroll-view.html
/// </summary>

public class ScrollerButton : MonoBehaviour
{
    private string Name;
    public Text ButtonText;
    public ScrollerView ScrollView;

    public void SetName(string name)
    {
        Name = name;
        if(ButtonText != null)
            ButtonText.text = name;
    }
    public void Button_Click()
    {
        ScrollView.ButtonClicked(Name);
    }


}
