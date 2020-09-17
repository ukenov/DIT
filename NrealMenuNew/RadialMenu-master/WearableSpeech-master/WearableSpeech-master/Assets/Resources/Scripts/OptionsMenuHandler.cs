using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenuHandler : MonoBehaviour
{
    public string homePage; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void RedirectHome()
    {
        Debug.Log("Redirect to the home page");
    }

    // Press when you want to go back one directory 
    public void GoBack()
    {
        Debug.Log("Go back one directory");
    }

    public void HelpMenu()
    {
        Debug.Log("This will toggle the help menu to open up");
    }

    public void SettingsModal()
    {
        Debug.Log("Pops open the Settings page so that you can edit your presets, such as color blidness settings / theme, etc...");
    }

}


