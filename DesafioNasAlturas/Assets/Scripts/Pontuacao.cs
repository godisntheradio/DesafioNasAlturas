using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class Pontuacao : MonoBehaviour
{
    #region Serialized Fields

    [SerializeField]
    private Text ScreenScore;
    public int Score { get; private set; }
    [SerializeField]
    private UnityEvent OnScore;
    [SerializeField]
    private bool IsMultiplayer = false;

    #endregion

    public int TopScore { get; private set; }

    AudioSource Audio;

    const string ScoreKey = "TopScore";
    const string ScoreKeyMP = "TopScoreMP";

    private void Awake()
    {
        Audio = GetComponent<AudioSource>();
        if (IsMultiplayer)
            TopScore = PlayerPrefs.GetInt(ScoreKeyMP);
        else
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
            if (IsMultiplayer)
                PlayerPrefs.SetInt(ScoreKeyMP, Score);
            else
                PlayerPrefs.SetInt(ScoreKey, Score);
            TopScore = Score;
        }
    }
}
