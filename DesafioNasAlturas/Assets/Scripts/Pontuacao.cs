using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    #region Serialized Fields

    [SerializeField]
    private Text ScreenScore;
    private int Score = 0;
    AudioSource Audio;

    #endregion

    public int TopScore { get; private set; }

    const string ScoreKey = "TopScore";

    private void Awake()
    {
        Audio = GetComponent<AudioSource>();
        TopScore = PlayerPrefs.GetInt(ScoreKey);
    }

    public void Increment()
    {
        Score++;
        ScreenScore.text = Score.ToString();
        Audio.Play();
    }
    public void Restart()
    {
        Score = 0;
        ScreenScore.text = Score.ToString();
    }
    public void SaveScore()
    {
        if (Score > TopScore)
        {
            PlayerPrefs.SetInt(ScoreKey, Score);
            TopScore = Score;
        }
    }
}
