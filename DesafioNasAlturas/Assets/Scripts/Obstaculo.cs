using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    #region Serialized Fields

    [SerializeField]
    public VariavelCompartilhadaFloat Speed;
    [SerializeField]
    private float MaxHeight = 1.8f;
    [SerializeField]
    private float MinHeight = -0.8f;

    #endregion

    void Start()
    {
        transform.Translate(Random.Range(MinHeight, MaxHeight) * Vector3.up);
    }

    void Update()
    {
        transform.Translate(-Vector3.right * Speed.Valor * Time.deltaTime);
    }
}
