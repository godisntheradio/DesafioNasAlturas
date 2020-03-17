using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    [SerializeField]
    private Text ScreenScore;
    private int Score = 0;
    AudioSource Audio;

    private void Awake()
    {
        Audio = GetComponent<AudioSource>();    
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
}
