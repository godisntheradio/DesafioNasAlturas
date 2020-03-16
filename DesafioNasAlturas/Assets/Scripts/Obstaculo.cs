using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    #region Serialized Fields

    [SerializeField]
    public float Speed = 1;
    [SerializeField]
    private float MaxHeight = 1.8f;
    [SerializeField]
    private float MinHeight = -0.8f;

    #endregion

    private float PlaneX;
    private bool HasBeenPassed = false;
    private Pontuacao Pontuacao;
    void Start()
    {
        transform.Translate(Random.Range(MinHeight, MaxHeight) * Vector3.up);
        PlaneX = GameObject.FindObjectOfType<Aviao>().transform.position.x;
        Pontuacao = GameObject.FindObjectOfType<Pontuacao>();
    }

    void Update()
    {
        if (!HasBeenPassed && transform.position.x < PlaneX)
        {
            Debug.Log("pontuou");
            Pontuacao.Increment();
            HasBeenPassed = true;
        }
        transform.Translate(-Vector3.right * Speed * Time.deltaTime);
    }
}
