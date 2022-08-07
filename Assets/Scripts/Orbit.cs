using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    [SerializeField] private float speedRotation = 75f;

    private void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        transform.Rotate(0, 0, speedRotation * Time.deltaTime);
    }
}
