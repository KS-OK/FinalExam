using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEditor;
using UnityEngine.UI;

public class StopPlaying : MonoBehaviour
{
    public Text writeScore;

    public void WriteScore()
    {
        string path = "Assets/scores.txt";

        writeScore.text = Points.points.ToString();

        //get score
        string scoreToBeWritten = writeScore.text;

        StreamWriter writer = new StreamWriter(path, true);

        writer.WriteLine(scoreToBeWritten);
        writer.Close();

        AssetDatabase.ImportAsset(path);
        TextAsset asset = (TextAsset)Resources.Load("scores");

        Debug.Log("Done writing");
    }

    public void StopGame()
    {
        WriteScore();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
