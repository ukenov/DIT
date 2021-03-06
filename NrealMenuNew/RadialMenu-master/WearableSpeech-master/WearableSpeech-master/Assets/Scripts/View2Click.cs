﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SimpleJSON;
using System.IO;

public class View2Click : MonoBehaviour
{
    public Text ButtonText;
    public UltimateRadialButtonInfo FirstBtnInfo;
    public UltimateRadialButtonInfo SecondBtnInfo;
    public UltimateRadialButtonInfo ThirdBtnInfo;
    public UltimateRadialButtonInfo FourthBtnInfo;
    public UltimateRadialButtonInfo FifthBtnInfo;
    public UltimateRadialButtonInfo SixthBtnInfo;

    [System.Obsolete]
    private void Start()
    {
        UltimateRadialMenu.UpdateRadialButton("OuterMain", "FirstBtn", FillRadio, FirstBtnInfo);
        UltimateRadialMenu.UpdateRadialButton("OuterMain", "SecondBtn", FillRadio, SecondBtnInfo);
        UltimateRadialMenu.UpdateRadialButton("OuterMain", "ThirdBtn", FillRadio, ThirdBtnInfo);
        UltimateRadialMenu.UpdateRadialButton("OuterMain", "FourthBtn", FillRadio, FourthBtnInfo);
        UltimateRadialMenu.UpdateRadialButton("OuterMain", "FifthBtn", FillRadio, FifthBtnInfo);
        UltimateRadialMenu.UpdateRadialButton("OuterMain", "SixthBtn", FillRadio, SixthBtnInfo);
    }

    public void FillRadio()
    {
        List<string> FieldsList = new List<string>();

        string path = Application.dataPath + "/circlesjson.json";
        string jsonString = File.ReadAllText(path);
        JSONObject circleJson = (JSONObject)JSON.Parse(jsonString);

        for (int i = 0; i < circleJson["innerCircles"].Count; i++)
        {
            if (circleJson["innerCircles"][i]["main_id"] == DB.mainCircleId && circleJson["innerCircles"][i]["name"] == ButtonText.text)
            {
                DB.innerCircleId = circleJson["innerCircles"][i]["id"].AsInt;
            }
        }

        for (int i = 0; i < circleJson["circleFields"].Count; i++)
        {
            if (circleJson["circleFields"][i]["innercircle_id"] == DB.innerCircleId)
            {
                FieldsList.Add(circleJson["circleFields"][i]["value"]);
            }
        }

        FirstBtnInfo.UpdateText(TrimText(FieldsList[0]));
        SecondBtnInfo.UpdateText(TrimText(FieldsList[1]));
        ThirdBtnInfo.UpdateText(TrimText(FieldsList[2]));
        FourthBtnInfo.UpdateText(TrimText(FieldsList[3]));
        FifthBtnInfo.UpdateText(TrimText(FieldsList[4]));
        SixthBtnInfo.UpdateText(TrimText(FieldsList[5]));
    }
    
    private string TrimText(string newText)
    {
        string text = newText;
        if (newText.Contains(" "))
        {
            text = "";
            int count = 0;
            foreach (char letter in newText)
            {
                if (letter == ' ' && count > 3)
                {
                    text += '\n';
                    count = 0;
                }
                else
                {
                    text += letter;
                    count++;
                }
            }
        }

        return text;
    }
}
