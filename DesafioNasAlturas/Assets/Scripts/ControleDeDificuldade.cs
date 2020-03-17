using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDeDificuldade : MonoBehaviour
{
    [SerializeField]
    private float TempoParaDificuldadeMax = 120.0f;
    private float Clock = 0.0f;
    public float Dificuldade { get; private set; }

    void Update()
    {
        Clock += Time.deltaTime;
        Dificuldade = Clock / TempoParaDificuldadeMax;
        Dificuldade = Mathf.Min(Dificuldade, 1.0f);
    }

    public void Restart()
    {
        Clock = 0.0f;
    }
}
