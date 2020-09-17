using System;
using System.Collections;
using System.Text;
using System.Collections.Generic;
using UnityEngine;

public class PizzaTree : MonoBehaviour
{
    // Declaring the dictionary 
    Dictionary<string, RadialContent> radialContent = new Dictionary<string, RadialContent>();

    List<RadialList> radialList = new List<RadialList>();

    // Functions used here are reference to the UltimateRadialButtonInfo Class
    public UltimateRadialButtonInfo buttonInfo;

    // This goes into radial buttons
    public UltimateRadialButtonInfo exampleButton;

    // https://www.youtube.com/watch?v=KSE3MMRRWiM
    // Start is called before the first frame update
    void Start()
    {
        UltimateRadialMenu.RegisterToRadialMenu("MenuTree", OrderMenu, exampleButton);
        buttonInfo.UpdateText("Order Food");


        RadialContent orderFoodRadial = new RadialContent(new List<string>{"Order Food"}, 1);
        RadialContent pizzaRadial = new RadialContent(new List<string> { "Pizza" }, 2);
        RadialContent pizzaSizeRadial = new RadialContent(new List<string> { "Small", "Medium", "Large", "X-Large", "Party Size" }, 3);
        RadialContent pizzaSauceRadial = new RadialContent(new List<string> { "Toppings", "Pizza Sauce", "Cheese" }, 4);
        RadialContent sauceToppings = new RadialContent(new List<string> { "Pizza Sauce(Light/Normal/Extra)", "BBQ Sauce", "Alfredo Sauce", "Hearty Marinara Sauce", "Ranch Dressing", "Garlic Parmesan Sauce" }, 5);
        RadialContent toppingsRadial = new RadialContent(new List<string> { "Pepperoni", "Brooklyn Pepperoni", "Sausage", "Beef Crumble", "Ham", "Bacon", "More Toppings" }, 6);
        RadialContent toppingsRadialMore = new RadialContent(new List<string> { "Chicken", "Anchovy", "Cheddar", "Feta", "Parmesan Asiago", "Provolone"}, 7);
        RadialContent paymentRadial = new RadialContent(new List<string> {"Deliver Now", "Toggle Purchase Method", "Place Order" }, 8);
        // Toggle Purchase method -> (Mastercard / debit card / Credit Card) 
        // Place Order -> Order Confirmation
        // Delivery Now -> (Use Geolocation to pick closes pizza store) 


        // Creating a strongly typed list of objects that can be accessed by index... Providing us the ability to use search, sort, and manipulate list... 
        radialList.Add(new RadialList() {RadialListName= "orderFoodRadial", RadialListId=0001 });
        radialList.Add(new RadialList() {RadialListName= "pizzaRadial", RadialListId=0002 });
        radialList.Add(new RadialList() {RadialListName= "pizzaSizeRadial", RadialListId=0003 });
        radialList.Add(new RadialList() {RadialListName= "pizzaSauceRadial", RadialListId=0004 });
        radialList.Add(new RadialList() {RadialListName= "sauceToppings", RadialListId=0005 });
        radialList.Add(new RadialList() {RadialListName= "toppingsRadial", RadialListId=0006 });
        radialList.Add(new RadialList() {RadialListName= "toppingsRadialMore", RadialListId=0007});
        radialList.Add(new RadialList() {RadialListName= "paymentRadial", RadialListId=0008 });
        // Write out all the parts in the RadialList. 
       // print("This is a line we are writting");
        /*
         *  foreach (RadialList aList in radialList)
        {
            print(aList);
        }
         * 
         */


    }


    void Awake()
    {
        
    }

    // This should trigger the multipage food ordering menu.
    
    public void OrderMenu()
    {
        exampleButton.UpdateText("PIZZA");

        Debug.Log("Order some food, this will take you to the next menu");
    }


}
