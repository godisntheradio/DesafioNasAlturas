using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    [SerializeField]
    private Text ScreenScore;
    private int Score = 0;

    public void Increment()
    {
        Score++;
        ScreenScore.text = Score.ToString();
    }
    public void Restart()
    {
        Score = 0;
        ScreenScore.text = Score.ToString();
    }
}
