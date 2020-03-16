using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponentInParent<Obstaculo>())
        {
            Destroy(collision.gameObject.transform.parent.gameObject);
        }
    }
}
