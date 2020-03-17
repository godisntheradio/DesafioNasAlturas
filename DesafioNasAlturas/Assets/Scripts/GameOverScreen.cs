using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOverScreen : MonoBehaviour
{
    [SerializeField]
    private Text RecordeText;
    [SerializeField]
    private Pontuacao Pontuacao;


    public void ShowGameOver()
    {
        gameObject.SetActive(true);
        RecordeText.text = Pontuacao.TopScore.ToString();
    }

    public void Restart()
    {
        gameObject.SetActive(false);
    }
}
