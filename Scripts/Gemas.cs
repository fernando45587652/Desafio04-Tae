using UnityEngine;

public class Gem : MonoBehaviour
{
    // Valor de la gema
    public int value = 1;

    private void OnTriggerEnter(Collider other)
    {
        // Si el jugador entra en contacto
        if (other.CompareTag("Player"))
        {
            // Accede al script del jugador y suma puntos
            PlayerInventory playerInv = other.GetComponent<PlayerInventory>();
            if (playerInv != null)
            {
                playerInv.AddGem(value);
            }

            // Destruye la gema recolectada
            Destroy(gameObject);
        }
    }
}