using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrossel : MonoBehaviour
{
    #region Serialized Fields
    [SerializeField]
    private VariavelCompartilhadaFloat Speed;

    #endregion

    #region Fields

    public Vector3 InitialPosition;
    public float ImageSize;

    #endregion


    void Awake()
    {
        InitialPosition = transform.position;
        ImageSize = (GetComponent<SpriteRenderer>().size.x * transform.localScale.x) / 2 ;
    }

    // Update is called once per frame
    void Update()
    {
        float deslocamento = Mathf.Repeat(Speed.Valor * Time.time, ImageSize);
        transform.Translate(Time.deltaTime * Speed.Valor * Vector3.left);
        transform.position = InitialPosition + Vector3.left * deslocamento;
    }
}
