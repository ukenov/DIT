using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// We're using a Scroll Rect and Mask inside of the main Canvas -> image 
/// http://gregandaduck.blogspot.com/2015/07/unity-ui-dynamic-buttons-and-scroll-view.html
/// </summary>
/// 


public class MasterScroller : MonoBehaviour
{

    public GameObject Button_Template;
    GameObject Scroller_Title;
    private List<string> NameList = new List<string>();
    GameObject go;


    // Start is called before the first frame update
    void Start()
    {
        Scroller_Title = GameObject.Find("ScrollerTwoTitleText");


        NameList.Add("Food & Beverages");
        NameList.Add("Driver");
        NameList.Add("Text Message");
        NameList.Add("Contacts");
        NameList.Add("Reminders");
        NameList.Add("button");
        NameList.Add("button");
        NameList.Add("button");
        NameList.Add("button");
        NameList.Add("button");
        NameList.Add("button");
        NameList.Add("button");
        NameList.Add("button");
        NameList.Add("button");


        foreach (string str in NameList)
        {
            go = Instantiate(Button_Template) as GameObject;
            go.SetActive(true);
            ScrollerButton TB = go.GetComponent<ScrollerButton>();
            TB.SetName(str);
            go.transform.SetParent(Button_Template.transform.parent);

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }


}




