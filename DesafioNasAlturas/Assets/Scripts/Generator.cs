using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{

    #region Serialized Properties

    [SerializeField]
    private GameObject Obstaculo;

    [SerializeField]
    private float Interval = 1.0f;

    #endregion

    #region Properties

    private float Clock = 0.0f;

    #endregion

    void Start()
    {
        Clock = Interval;
    }
    
    void Update()
    {
        Clock -= Time.deltaTime;
        if (Clock <= 0)
        {
            Spawn();
            Clock = Interval;
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
        Clock = Interval;
    }
}
