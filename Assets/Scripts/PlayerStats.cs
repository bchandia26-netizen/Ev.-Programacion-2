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
}