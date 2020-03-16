using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{
    [SerializeField]
    public float Force = 1;

    private Rigidbody2D Rigidbody;
    private Manager GameManager;
    private Vector3 InitialPosition;
    void Awake()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
        GameManager = GameObject.FindObjectOfType<Manager>();
        InitialPosition = transform.position;
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
        Rigidbody.velocity = Vector2.zero;
        Rigidbody.AddForce(Vector2.up * Force, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody.simulated = false;
        GameManager.EndGame();
    }
    public void Restart()
    {
        Rigidbody.simulated = true;
        transform.position = InitialPosition;
    }
}
