using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOverScreen : MonoBehaviour
{
    [SerializeField]
    private Text RecordeText;
    [SerializeField]
    private Sprite Gold;
    [SerializeField]
    private Sprite Silver;
    [SerializeField]
    private Sprite Bronze;
    [SerializeField]
    private Pontuacao Pontuacao;
    [SerializeField]
    private Image MedalImage;

    public void ShowGameOver()
    {
        gameObject.SetActive(true);
        RecordeText.text = Pontuacao.TopScore.ToString();
        MedalImage.sprite = GetPerformance(Pontuacao.Score);
    }

    public void Restart()
    {
        gameObject.SetActive(false);
    }
    private Sprite GetPerformance(int score)
    {
        if (score > Pontuacao.TopScore - 2)
        {
            return Gold;
        }
        else if(score > Pontuacao.TopScore / 2)
        {
            return Silver;
        }
        else
        {
            return Bronze;
        }
    }
}
