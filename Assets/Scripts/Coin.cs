using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private AudioClip pickupSound;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out PlayerInventory inventory))
        {
            inventory.AddCoin();
            SoundManager.Instance?.PlaySfx(pickupSound);
            Destroy(gameObject);
        }
    }
}