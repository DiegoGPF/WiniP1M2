using UnityEngine;

public class Lose : MonoBehaviour
{
    public float velocidadRotacion = 50f; // Velocidad de rotación del objeto

    private void Update()
    {
        // Girar el objeto en el eje Y
        transform.Rotate(Vector3.up * velocidadRotacion * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Verificar si el objeto que colisionó es el jugador
        if (other.CompareTag("Player"))
        {
            // Desactivar el jugador
            other.gameObject.SetActive(false);
        }
    }
}