using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField]
    private GameOverScreen GameOverScreen;
    [SerializeField]
    private Aviao Plane;
    [SerializeField]
    private Generator Generator;
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
    public void Restart()
    {
        Time.timeScale = 1;
        GameOverScreen.Restart();
        Plane.Restart();
        Generator.Restart();
        Pontuacao.Restart();
        ControleDeDificuldade.Restart();
    }

}
