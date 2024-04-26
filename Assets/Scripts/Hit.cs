using UnityEngine;

public class Hit : MonoBehaviour
{
    public float fuerzaGolpe = 10f; // Fuerza del golpe ajustable

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Aseg�rate de que el objeto sea el personaje
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb != null)
            {
                // Calcula la direcci�n del golpe
                Vector3 direccionGolpe = (other.transform.position - transform.position).normalized;

                // Aplica la fuerza al personaje
                rb.AddForce(direccionGolpe * fuerzaGolpe, ForceMode.Impulse);

                // Reproduce una animaci�n de vuelo (puedes ajustar esto seg�n tu configuraci�n de animaci�n)
                // other.GetComponent<Animator>().SetTrigger("Volar");

                // Opcional: Control de la rotaci�n del personaje en el aire
                // rb.AddTorque(Vector3.up * 10f, ForceMode.Impulse);
            }
        }
    }
}