using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    public int Vida= 100;

    // Función pública para que otros scripts puedan modificar las gemas
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