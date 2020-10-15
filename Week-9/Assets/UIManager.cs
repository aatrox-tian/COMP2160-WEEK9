using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public ScoreKeeper scoreKeeper;

    public void UpdateScoreText ()
    {
        scoreText.text = "Score: " + scoreKeeper.Score;
    }
}
