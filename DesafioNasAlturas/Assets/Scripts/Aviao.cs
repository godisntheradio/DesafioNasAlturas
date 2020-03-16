using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{
    [SerializeField]
    public float Force = 1;

    private Rigidbody2D Rigidbody;
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (Input.GetButtonDown("Impulse"))
        {
            ApplyMovement();
        }
    }

    public void ApplyMovement()
    {
        Rigidbody.AddForce(Vector2.up * Force, ForceMode2D.Impulse);
    }
}
