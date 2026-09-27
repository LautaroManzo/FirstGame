using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerRespawn : MonoBehaviour
{
    [SerializeField] private AudioClip hurtSound;

    private Rigidbody2D rb;
    private Vector3 spawnPosition;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        spawnPosition = transform.position;
    }

    public void Respawn()
    {
        SoundManager.Instance?.PlaySfx(hurtSound);
        rb.linearVelocity = Vector2.zero;
        transform.position = spawnPosition;
    }
}