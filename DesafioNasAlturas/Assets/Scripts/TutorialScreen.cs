using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TutorialScreen : MonoBehaviour
{
    private Animator Animator;
    [SerializeField]
    UnityEvent OnPlayerStarted;

    public void StartPlaying()
    {
        OnPlayerStarted.Invoke();
    }
    private void Start()
    {
        Animator = GetComponent<Animator>();
    }
    public void PressKey()
    {
        Animator.SetBool("CanStart", true);
    }
}
