using UnityEngine;


public class Hit : MonoBehaviour
{
    
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