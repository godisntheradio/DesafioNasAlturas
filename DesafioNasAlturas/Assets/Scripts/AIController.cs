using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AIController : MonoBehaviour
{
    [Header("Input Config")]
    [SerializeField]
    private UnityEvent OnImpulseRequest;
    [SerializeField]
    private float Interval;

    private void Start()
    {
        StartCoroutine(ApplyImpulse());
    }

    void Update()
    {
        
    }

    private IEnumerator ApplyImpulse()
    {
        while(true)
        {
            yield return new WaitForSeconds(Interval);
            OnImpulseRequest.Invoke();

        }
    }
}
