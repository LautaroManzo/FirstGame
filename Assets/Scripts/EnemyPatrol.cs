using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private float patrolDistance = 3f;

    private Vector3 startPosition;
    private int direction = 1;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        startPosition = transform.position;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        transform.position += Vector3.right * direction * speed * Time.deltaTime;

        float offset = transform.position.x - startPosition.x;

        if (offset >= patrolDistance)
        {
            direction = -1;
        }
        else if (offset <= -patrolDistance)
        {
            direction = 1;
        }

        spriteRenderer.flipX = direction > 0;
    }

    private void OnDrawGizmosSelected()
    {
        Vector3 center = Application.isPlaying ? startPosition : transform.position;
        Gizmos.color = Color.red;
        Gizmos.DrawLine(center + Vector3.left * patrolDistance, center + Vector3.right * patrolDistance);
    }
}