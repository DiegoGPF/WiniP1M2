using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float baseRotationSpeed = 30f;
    public float accelerationRate = 10f;

    private float currentRotationSpeed;

    void Start()
    {
        currentRotationSpeed = baseRotationSpeed;
    }

    void Update()
    {
        // Aumentar la velocidad de rotación cada fotograma
        currentRotationSpeed += accelerationRate * Time.deltaTime;

        // Rotar el objeto
        transform.Rotate(new Vector3(0, currentRotationSpeed, 0) * Time.deltaTime);
    }
}