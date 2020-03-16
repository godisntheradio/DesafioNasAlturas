using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrossel : MonoBehaviour
{
    #region Serialized Fields
    [SerializeField]
    private float _Speed;

    #endregion

    #region Properties

    public float Speed { get => _Speed; set => _Speed = value; }

    #endregion

    #region Fields

    public Vector3 InitialPosition;
    public float FloorSize;

    #endregion


    void Awake()
    {
        InitialPosition = transform.position;
        FloorSize = GetComponent<SpriteRenderer>().size.x * transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Time.deltaTime * Speed * Vector3.left);
        if ((transform.position - InitialPosition).magnitude >= FloorSize)
        {
            transform.position = InitialPosition;
        }
    }
}
