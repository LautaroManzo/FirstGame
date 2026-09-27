using System.Collections;
using TMPro;
using UnityEngine;

public class MessageUI : MonoBehaviour
{
    public static MessageUI Instance { get; private set; }

    [SerializeField] private TMP_Text messageText;
    [SerializeField] private float defaultDuration = 2f;

    private Coroutine hideRoutine;

    private void Awake()
    {
        Instance = this;
        messageText.text = "";
    }

    public void Show(string message, float duration = 0f)
    {
        messageText.text = message;

        if (hideRoutine != null)
        {
            StopCoroutine(hideRoutine);
        }

        hideRoutine = StartCoroutine(HideAfter(duration > 0f ? duration : defaultDuration));
    }

    private IEnumerator HideAfter(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        messageText.text = "";
    }
}