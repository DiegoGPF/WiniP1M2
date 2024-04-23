using UnityEngine;

public class PlayerTube : MonoBehaviour
{
    public float pushForce = 10f; // Fuerza de impulso al tocar el objeto rotatorio

    void OnCollisionEnter(Collision collision)
    {
        // Verificar si el jugador colisiona con el objeto rotatorio y no est� tocando el piso
        if (collision.gameObject.CompareTag("RotatingObject") && !IsGrounded())
        {
            // Obtener la direcci�n opuesta al frente del objeto rotatorio
            Vector3 pushDirection = -collision.gameObject.transform.forward;

            // Aplicar fuerza al jugador en la direcci�n calculada
            GetComponent<Rigidbody>().AddForce(pushDirection * pushForce, ForceMode.Impulse);
        }
    }

    bool IsGrounded()
    {
        // Lanzar un rayo hacia abajo para verificar si el jugador est� tocando el suelo
        return Physics.Raycast(transform.position, -Vector3.up, 0.1f);
    }
}