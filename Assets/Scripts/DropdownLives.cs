using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownLives : MonoBehaviour
{
    public Dropdown LifeDropdown;
    public static float lives;
    public Text lifeText;

    public void ChooseLives(int val)
    {
        switch (LifeDropdown.value)
        {
            case 1:
                lives = 1f;
                lifeText.text = "Your lives: " + lives;
                break;
            case 2:
                lives = 2f;
                lifeText.text = "Your lives: " + lives;
                break;
            case 3:
                lives = 3f;
                lifeText.text = "Your lives: " + lives;
                break;
            case 4:
                lives = 4f;
                lifeText.text = "Your lives: " + lives;
                break;
            case 5:
                lives = 5f;
                lifeText.text = "Your lives: " + lives;
                break;
            case 6:
                lives = 6f;
                lifeText.text = "Your lives: " + lives;
                break;
            case 7:
                lives = 7f;
                lifeText.text = "Your lives: " + lives;
                break;
            case 8:
                lives = 8f;
                lifeText.text = "Your lives: " + lives;
                break;
            case 9:
                lives = 9f;
                lifeText.text = "Your lives: " + lives;
                break;
            default: 
                lives = 3f;
                lifeText.text = "Your lives: " + lives;
                break;
        }

    }
}
