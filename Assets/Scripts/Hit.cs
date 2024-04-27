using UnityEngine;

public class Hit : MonoBehaviour
{
    public GameObject pauseMenu; // Referencia al men� de pausa que quieres activar

    private void OnTriggerEnter(Collider other)
    {
        // Verificar si el objeto que colision� es el jugador
        if (other.CompareTag("Player"))
        {
            // Desactivar el jugador
            other.gameObject.SetActive(false);

            // Activar el men� de pausa si existe
            if (pauseMenu != null)
            {
                pauseMenu.SetActive(true);
            }
        }
    }
}