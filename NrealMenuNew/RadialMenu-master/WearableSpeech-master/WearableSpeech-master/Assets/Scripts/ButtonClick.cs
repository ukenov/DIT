using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    private Button mbutton;
    private float secondsCount;
    private bool conditionForTime;

    private GameObject circleImage;

    void Update()
    {
        UpdateTimer();
    }

    void Awake()
    {
        circleImage = GameObject.Find("circleImage");
        mbutton = transform.GetComponent<Button>();
    }

    //when pointer click, set the cube color to random color
    public void OnPointerClick(PointerEventData eventData)
    {
        //mbutton.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }

    //when pointer enter hover start timer
    public void OnPointerEnter(PointerEventData eventData)
    {
        conditionForTime = true;
        StartCoroutine(ExecuteAfterTime(2));
    }

    //when pointer exit hover stop timer, drop to 0s
    public void OnPointerExit(PointerEventData eventData)
    {
        secondsCount = 0;
        conditionForTime = false;
        circleImage.GetComponent<Image>().fillAmount = 0;
    }

    public void UpdateTimer()
    {
        if (conditionForTime)
        {
            secondsCount += Time.deltaTime;
            circleImage.GetComponent<Image>().fillAmount = secondsCount / 2;
        }
    }

    //delay
    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        // Code to execute after the delay
        if (secondsCount > 2)
        {
            mbutton.onClick.Invoke();
        }
    }
}