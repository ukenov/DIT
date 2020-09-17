using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CallKeyboard : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject keyboard;

    //when pointer click, set the cube color to random color
    public void OnPointerClick(PointerEventData eventData)
    {
        //mbutton.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }

    //when pointer hover, set the cube color to green
    public void OnPointerEnter(PointerEventData eventData)
    {
        keyboard.SetActive(true);
        GameObject.Find("OuterMainMenuReplacement").SetActive(false);
        GameObject.Find("middleMenuReplacement").SetActive(false);
        GameObject.Find("InnerMenuReplacement").SetActive(false);
        GameObject.Find("circle").SetActive(false);
    }

    //when pointer exit hover, set the cube color to white
    public void OnPointerExit(PointerEventData eventData)
    {
    }
}