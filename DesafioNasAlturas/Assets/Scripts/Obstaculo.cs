using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField]
    public float Speed = 1;
    
    void Start()
    {
            
    }

    void Update()
    {
        transform.Translate(-Vector3.right * Speed * Time.deltaTime);
    }
}
