using UnityEngine;

public class GemScript : MonoBehaviour
{ 
private void OnTriggerEnter2D(Collider2D collision)
{
    if (collision.CompareTag("Player"))
    {

        print("¡Gema recolectada!");
        Destroy(gameObject);

    }
}
}