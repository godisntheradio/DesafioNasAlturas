using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{

    [Header("Input Config")]
    [SerializeField]
    private UnityEvent OnAxisPress;
    [SerializeField]
    private string Axis;

    void Update()
    {
        if (Input.GetButtonDown(Axis))
            OnAxisPress.Invoke();
    }
}
