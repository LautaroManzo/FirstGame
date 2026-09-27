using UnityEngine;
using UnityEngine.UI;

public class KeyUI : MonoBehaviour
{
    [SerializeField] private PlayerInventory inventory;
    [SerializeField] private Image keyImage;
    [SerializeField] private Color missingColor = new Color(0f, 0f, 0f, 0.5f);

    private void OnEnable()
    {
        inventory.KeyPickedUp += ShowKey;
    }

    private void OnDisable()
    {
        inventory.KeyPickedUp -= ShowKey;
    }

    private void Start()
    {
        keyImage.color = inventory.HasKey ? Color.white : missingColor;
    }

    private void ShowKey()
    {
        keyImage.color = Color.white;
    }
}