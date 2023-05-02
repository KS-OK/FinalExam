using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowLives : MonoBehaviour
{
    public static float ShowTheLives = DropdownLives.lives;
    public GameObject LivesText;

    public void Start()
    {
        LivesText.GetComponent<Text>().text = ShowTheLives.ToString();
    }

    public void IncreaseLives()
    {
        ShowTheLives++;
        LivesText.GetComponent<Text>().text = ShowTheLives.ToString();
    }

    public void DecreaseLives()
    {
        ShowTheLives--;
        LivesText.GetComponent<Text>().text = ShowTheLives.ToString();
    }
}
