using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField]
    private GameObject GameOverScreen;
    [SerializeField]
    private Aviao Plane;
    [SerializeField]
    private Generator Generator;
    [SerializeField]
    private Pontuacao Pontuacao;

    public void EndGame()
    {
        Time.timeScale = 0;
        GameOverScreen.SetActive(true);
    }
    public void Restart()
    {
        Time.timeScale = 1;
        GameOverScreen.SetActive(false);
        Plane.Restart();
        Generator.Restart();
        Pontuacao.Restart();
    }
}
