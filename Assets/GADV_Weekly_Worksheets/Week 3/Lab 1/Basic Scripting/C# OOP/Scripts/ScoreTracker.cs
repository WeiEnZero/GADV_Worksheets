using UnityEngine;
public class ScoreTracker
{
    private int score;

    public void ResetScore()
    {
        score = 0;
    }

    public void GetScore()
    {
        Debug.Log("Your Score is " + score);
    }
}