using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameTransfer : MonoBehaviour
{
    public static string theName;
    public GameObject inputField; //Drag the "Text" object from NameInputField to here.
    public GameObject textDisplay; //Example: Input Field: Text
                                   //         Text Display: NameText

    public void StoreName()
    {
        theName = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = "Your name is " + theName ;
    }
}
