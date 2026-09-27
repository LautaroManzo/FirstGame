using UnityEngine;

public class Key : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out PlayerInventory inventory))
        {
            inventory.PickUpKey();
            Destroy(gameObject);
        }
    }
}