using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaoPiscando : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Impulse"))
        {
            GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
