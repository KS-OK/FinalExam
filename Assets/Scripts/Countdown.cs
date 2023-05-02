using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    //public Text timeLimitText;
    public Text remainingTimeText;

    private float timelimit = TimeSlider.Time;
    private float timeRemaining;

    // Start is called before the first frame update
    void Start()
    {
        timeRemaining = timelimit;

        //timeLimitText.text = "Time limit: " + timelimit.ToString("F2");
        remainingTimeText.text = "Time remaining: " + timeRemaining.ToString("F2");
    }


    // Update is called once per frame
    void Update()
    {
        timeRemaining -= Time.deltaTime;
        if (timeRemaining >= 0)
        {
            remainingTimeText.text = "Time remaining: " + timeRemaining.ToString("F2");
        }
        else
        {
            remainingTimeText.text = "Game Over";
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}
