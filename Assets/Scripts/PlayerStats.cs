using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int gems = 0;

    // Función pública para que otros scripts puedan modificar las gemas
    public void AddCoin(int amount)
    {
        gems += amount;
        Debug.Log("Gemas actuales: " + gems);
    }
    public int Vida = 100;
    public void DealDamage(int amount)
    {
        Vida -= amount;

        if (Vida > 0)
        {
            Debug.Log("Vida Actual: " + Vida);
        }
        else
        {
            Debug.Log("Vida actual: 0");
        }
    }
}