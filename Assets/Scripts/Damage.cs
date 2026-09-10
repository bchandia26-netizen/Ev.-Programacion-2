using UnityEngine;

public class Damage : MonoBehaviour
{
    public int DamagePlayer = 10;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Comunicación dinámica: buscamos si el objeto tiene PlayerStats
        PlayerLife stats = collision.GetComponent<PlayerLife>();

        if (stats != null) // Si no es nulo, significa que es el jugador
        {
            stats.DealDamage(DamagePlayer);
            Destroy(gameObject); // Destruimos la moneda tras recogerla
        }
    }
}