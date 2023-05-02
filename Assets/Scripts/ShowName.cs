using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowName : MonoBehaviour
{
    string ShowTheName = NameTransfer.theName;
    public GameObject NameText;

    public void Start()
    {
        NameText.GetComponent<Text>().text = ShowTheName;
    }
}
