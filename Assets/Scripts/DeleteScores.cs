using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;
using UnityEngine.UI;

public class DeleteScores : MonoBehaviour
{
    public void ClearScore()
    {
        string Filepath = @"scores.txt";
        System.IO.File.Delete(Filepath);
        System.IO.FileStream Str = System.IO.File.Create(Filepath);
    }
}
