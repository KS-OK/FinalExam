using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeSlider : MonoBehaviour
{
    public static float Time = 45;
    public Slider ChangeTime;
    public Text ShowTime;

    public void AdjustTime()
    {
        Time = ChangeTime.value;
        ShowTime.text = "Time: " + Time.ToString();
    }
}
