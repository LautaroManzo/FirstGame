using TMPro;
using UnityEngine;

public class CoinsUI : MonoBehaviour
{
    [SerializeField] private PlayerInventory inventory;
    [SerializeField] private TMP_Text coinsText;

    private void OnEnable()
    {
        inventory.CoinsChanged += UpdateText;
    }

    private void OnDisable()
    {
        inventory.CoinsChanged -= UpdateText;
    }

    private void Start()
    {
        UpdateText(inventory.Coins);
    }

    private void UpdateText(int coins)
    {
        coinsText.text = $"Monedas: {coins}";
    }
}