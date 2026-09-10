using UnityEngine;

public class PlayerGem : MonoBehaviour
{
    public int gemValue = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Comunicación dinámica: buscamos si el objeto tiene PlayerStats
        PlayerStats stats = collision.GetComponent<PlayerStats>();

        if (stats != null) // Si no es nulo, significa que es el jugador
        {
            stats.AddCoin(gemValue);
            Destroy(gameObject); // Destruimos la moneda tras recogerla
        }
    }
}
