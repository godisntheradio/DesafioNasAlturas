using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Aviao : MonoBehaviour
{
    #region Serialized properties

    [SerializeField]
    public float Force = 1;

    [SerializeField]
    private UnityEvent OnColliderHit;
    [SerializeField]
    private UnityEvent OnObstaculoPass;

    #endregion

    #region Fields

    private Rigidbody2D Rigidbody;
    private Animator Animator;
    private ParticleSystem Particles;
    private Vector3 InitialPosition;

    private bool ShouldApplyForce = false;

    #endregion
    void Awake()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
        Particles = GetComponentInChildren<ParticleSystem>();
        InitialPosition = transform.position;
    }

    private void Update()
    {
        
        Animator.SetFloat("VelocidadeY", Rigidbody.velocity.y);
        
    }
    public void SetApplyForce()
    {
        ShouldApplyForce = true;
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
    public void Restart()
    {
        Rigidbody.simulated = true;
        Rigidbody.MovePosition(InitialPosition);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody.simulated = false;
        OnColliderHit.Invoke();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Obstaculo>())
        {
            OnObstaculoPass.Invoke();
        }
    }
}
