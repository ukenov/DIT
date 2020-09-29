using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using SimpleJSON;


public class ScrollerView : MonoBehaviour
{
    public GameObject Button_Template;
    public GameObject Button_Template2;
    GameObject Scroller_Title;
    private List<string> NameList = new List<string>();
    private List<string> InnerCirclesList = new List<string>();
    GameObject go;
    void Start()
    {
        Scroller_Title = GameObject.Find("ScrollerTwoTitleText");

        string path = Application.dataPath + "/circlesjson.json";
        string jsonString = File.ReadAllText(path);
        JSONObject circleJson = (JSONObject)JSON.Parse(jsonString);

        for (int i = 0; i < circleJson["mainCircles"].Count; i++)
        {
            NameList.Add(circleJson["mainCircles"][i]["name"]);
        }

        foreach (string str in NameList)
        {
           go = Instantiate(Button_Template) as GameObject;
            go.SetActive(true);
           ScrollerButton TB = go.GetComponent<ScrollerButton>();
            TB.SetName(str);
           go.transform.SetParent(Button_Template.transform.parent);
        }
  }
 
     public void ButtonClicked(string str)
    {
        Debug.Log(str + " button clicked.");
        if(Scroller_Title.GetComponent<Text>().text != str)
        {
            Scroller_Title.GetComponent<Text>().text = str;

            string path = Application.dataPath + "/circlesjson.json";
            string jsonString = File.ReadAllText(path);
            JSONObject circleJson = (JSONObject)JSON.Parse(jsonString);

            for (int i = 0; i < circleJson["mainCircles"].Count; i++)
            {
                if (circleJson["mainCircles"][i]["name"] == str)
                {
                    DB.mainCircleId = circleJson["mainCircles"][i]["id"].AsInt;
                }
            }

            for (int i = 0; i < circleJson["innerCircles"].Count; i++)
            {
                if (circleJson["innerCircles"][i]["main_id"] == DB.mainCircleId)
                {
                    InnerCirclesList.Add(circleJson["innerCircles"][i]["name"]);
                    Debug.Log(circleJson["innerCircles"][i]["name"]);
                }
            }

            foreach (string item in InnerCirclesList)
            {
                go = Instantiate(Button_Template2) as GameObject;
                go.SetActive(true);
                ScrollerButton TB = go.GetComponent<ScrollerButton>();
                TB.SetName(item);
                go.transform.SetParent(Button_Template2.transform.parent);
                go.transform.position = Button_Template2.transform.position;
                go.transform.rotation = Button_Template2.transform.rotation;
            }
        }
    }
}

/*
 * 
        NameList.Add("Food & Beverages");
        NameList.Add("Driver");
        NameList.Add("Text Message");
        NameList.Add("Contacts");
        NameList.Add("Reminders");
        NameList.Add("Dominos");
        NameList.Add("Starbucks");
        NameList.Add("Pizza Nova");
        NameList.Add("Pizza Hut");
        NameList.Add("Pizza Pizza");
        NameList.Add("Tim Hortons");
        NameList.Add("McDonald's");
        NameList.Add("Wendy's");
        NameList.Add("Popeyes");
        NameList.Add("A&W");
        NameList.Add("Burger King");
        NameList.Add("Burger Priest");
        NameList.Add("Chipotle");
 */
