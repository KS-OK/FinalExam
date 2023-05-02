using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData
{
    public string name = NameTransfer.theName;
    public int score = Points.points;
    public float playerlives = ShowLives.ShowTheLives;

    public PlayerData(string name, int score, float playerlives)
    {
        this.name = name;
        this.score = score;
        this.playerlives = playerlives;
    }

    public override string ToString()
    {
        return $"{name} is at score of {score} with {playerlives} lives.";
    }
}
