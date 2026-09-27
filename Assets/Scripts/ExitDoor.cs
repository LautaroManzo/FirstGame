using UnityEngine;

public class ExitDoor : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.TryGetComponent(out PlayerInventory inventory)) return;

        if (inventory.HasKey)
        {
            Debug.Log("¡Nivel completado!");
        }
        else
        {
            Debug.Log("Necesitás la llave");
        }
    }
}