using UnityEngine;

public class SceneMusic : MonoBehaviour
{
    [SerializeField] private AudioClip music;

    private void Start()
    {
        if (SoundManager.Instance != null)
            SoundManager.Instance.PlayMusic(music);
    }
}