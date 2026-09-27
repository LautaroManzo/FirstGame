using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out PlayerInventory inventory))
        {
            inventory.AddCoin();
            Destroy(gameObject);
        }
    }
}