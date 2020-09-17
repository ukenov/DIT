using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlaveScroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClicked(string str)
    {
        Debug.Log(str + " button clicked.");

        // When Food & Beverages button is selected, change the title text to the Selection and input the list of buttons for that category
        // TODO: Swap the if statement with a dictionary when the rest of the buttons are being used (not necessary for a mockup...) 
        if (str == "Food & Beverages")
        {

            // go.SetActive(false);

            // Now pass the list of buttons to the Food & Beverages Scroller....

            /*
            foreach (string list in Food_Beverages_List)
            {
                GameObject create = Instantiate(Button_Template) as GameObject;
                Debug.Break();
                create.SetActive(true);
                ScrollerButton TB2 = create.GetComponent<ScrollerButton>();
                TB2.SetName(list);
                create.transform.SetParent(Button_Template.transform.parent);

            }
            */

        }

    }
}
