using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public static int points = 0;
    public GameObject pointsText;

    public void Start()
    {
        pointsText.GetComponent<Text>().text = points.ToString();
    }

    public void IncreasePoints()
    {
        points++;
        pointsText.GetComponent<Text>().text = points.ToString();
    }

    public void DecreasePoints()
    {
        points--;
        pointsText.GetComponent<Text>().text = points.ToString();
    }
}
