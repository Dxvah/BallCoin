using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoMoneda : MonoBehaviour
{
   
    [SerializeField]

    float rotacionY;

    void Update()
    {
        transform.Rotate(0.0f, rotacionY * Time.deltaTime, 0f);
    }
}
