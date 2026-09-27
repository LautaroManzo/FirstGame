using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitDoor : MonoBehaviour
{
    [SerializeField] private float delayBeforeLoad = 1.5f;

    private bool isCompleted;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (isCompleted) return;
        if (!other.TryGetComponent(out PlayerInventory inventory)) return;
        if (!inventory.HasKey) return;

        isCompleted = true;
        StartCoroutine(CompleteLevel());
    }

    private IEnumerator CompleteLevel()
    {
        MessageUI.Instance.Show("¡Nivel completado!", delayBeforeLoad);
        yield return new WaitForSeconds(delayBeforeLoad);

        int nextIndex = SceneManager.GetActiveScene().buildIndex + 1;

        if (nextIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextIndex);
        }
        else
        {
            MessageUI.Instance.Show("¡Ganaste!", 3f);
            yield return new WaitForSeconds(3f);
            SceneManager.LoadScene(0);
        }
    }
}