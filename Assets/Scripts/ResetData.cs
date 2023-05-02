using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetData : MonoBehaviour
{
    private void Awake()
    {
        Points.points = 0;
        DropdownLives.lives = 0f;
    }

}
