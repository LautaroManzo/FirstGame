using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] private AudioClip pickupSound;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out PlayerInventory inventory))
        {
            inventory.PickUpKey();
            SoundManager.Instance?.PlaySfx(pickupSound);
            Destroy(gameObject);
        }
    }
}