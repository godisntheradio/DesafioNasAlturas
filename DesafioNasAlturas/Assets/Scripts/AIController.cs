using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AIController : MonoBehaviour
{
    [Header("Input Config")]
    [SerializeField]
    private UnityEvent OnImpulseRequest;

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
            yield return new WaitForSeconds(0.8f);
            OnImpulseRequest.Invoke();

        }
    }
}
