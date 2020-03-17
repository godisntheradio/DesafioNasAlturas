using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{
    [SerializeField]
    public float Force = 1;

    private Rigidbody2D Rigidbody;
    private Animator Animator;
    private Manager GameManager;
    private Vector3 InitialPosition;

    private bool ShouldApplyForce = false;
    
    void Awake()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
        GameManager = GameObject.FindObjectOfType<Manager>();
        InitialPosition = transform.position;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Impulse"))
            ShouldApplyForce = true;
        Animator.SetFloat("VelocidadeY", Rigidbody.velocity.y);
        
    }

    void FixedUpdate()
    {
        if (ShouldApplyForce)
            ApplyMovement();
    }

    public void ApplyMovement()
    {
        Rigidbody.velocity = Vector2.zero;
        Rigidbody.AddForce(Vector2.up * Force, ForceMode2D.Impulse);
        ShouldApplyForce = false;
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
