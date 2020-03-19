using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Aviao Aviao;
    Carrossel[] Carrossels;
    Generator Gerador;

    private bool IsActive = true;
    private void Start()
    {
        Carrossels = GetComponentsInChildren<Carrossel>();
        Gerador = GetComponentInChildren<Generator>();
        Aviao = GetComponentInChildren<Aviao>();
    }
    public void Deactivate()
    {
        foreach (Carrossel item in Carrossels)
        {
            item.enabled = false;
        }
        Gerador.Stop();
        foreach (Obstaculo item in GetComponentsInChildren<Obstaculo>())
        {
            item.enabled = false;
        }
        IsActive = false;
    }
    public void Activate()
    {
        if (!IsActive)
        {
            foreach (Obstaculo item in GetComponentsInChildren<Obstaculo>())
            {
                Destroy(item.gameObject);
            }
            foreach (Carrossel item in Carrossels)
            {
                item.enabled = true;
            }
            Gerador.Resume();
            Aviao.Restart();
            IsActive = true;
        }
    }
    public void Restart()
    {
        foreach (Obstaculo item in GetComponentsInChildren<Obstaculo>())
        {
            Destroy(item.gameObject);
        }
        foreach (Carrossel item in Carrossels)
        {
            item.enabled = true;
        }
        Gerador.Restart();
        Aviao.Restart();
        IsActive = true;
    }

}
