﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{

    #region Serialized Properties

    [SerializeField]
    private GameObject Obstaculo;

    [SerializeField]
    private ControleDeDificuldade Controle;

    [SerializeField]
    private float MaxInterval = 1.0f;
    [SerializeField]
    private float MinInterval = 1.0f;

    #endregion

    #region Properties

    private float Clock = 0.0f;

    #endregion

    void Start()
    {
        Clock = MinInterval;
    }
    
    void Update()
    {
        Clock -= Time.deltaTime;
        if (Clock <= 0)
        {
            Spawn();
            Clock = Mathf.Lerp(MinInterval, MaxInterval, Controle.Dificuldade);
        }
    }

    void Spawn()
    {
        GameObject.Instantiate(Obstaculo, transform.position, transform.rotation);
    }
    public void Restart()
    {
        foreach (var item in FindObjectsOfType<Obstaculo>())
        {
            Destroy(item.gameObject);
        }
        Clock = MaxInterval;
    }
}
