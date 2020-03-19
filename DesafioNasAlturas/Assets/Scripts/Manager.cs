using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField]
    private GameOverScreen GameOverScreen;
    [SerializeField]
    private Pontuacao Pontuacao;
    [SerializeField]
    private ControleDeDificuldade ControleDeDificuldade;

    public void EndGame()
    {
        Time.timeScale = 0;
        Pontuacao.SaveScore();
        GameOverScreen.ShowGameOver();
    }
    public virtual void Restart()
    {
        Time.timeScale = 1;
        GameOverScreen.Restart();
        foreach (Player item in FindObjectsOfType<Player>())
        {
            item.Restart();
        }
        foreach (Generator item in FindObjectsOfType<Generator>())
        {
            item.Restart();
        }
        Pontuacao.Restart();
        ControleDeDificuldade.Restart();
    }

}
