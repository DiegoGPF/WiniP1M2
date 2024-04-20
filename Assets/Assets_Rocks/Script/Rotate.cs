using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float baseRotationSpeed = 30f;
    public float accelerationRate = 10f;
    public float pushForceMultiplier = 5f; // Multiplicador de la fuerza de empuje

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

    void OnCollisionEnter(Collision collision)
    {
        // Verificar si el objeto colisionado tiene un Rigidbody
        Rigidbody otherRigidbody = collision.gameObject.GetComponent<Rigidbody>();

        if (otherRigidbody != null)
        {
            // Calcular la fuerza de empuje basada en la velocidad actual de rotación
            float pushForce = currentRotationSpeed * pushForceMultiplier;

            // Aplicar la fuerza de empuje al objeto colisionado
            otherRigidbody.AddForce(transform.forward * pushForce, ForceMode.Impulse);
        }
    }
}