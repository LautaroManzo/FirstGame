using System;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public bool HasKey { get; private set; }
    public int Coins { get; private set; }

    public event Action<int> CoinsChanged;
    public event Action KeyPickedUp;

    public void PickUpKey()
    {
        HasKey = true;
        KeyPickedUp?.Invoke();
    }

    public void AddCoin()
    {
        Coins++;
        CoinsChanged?.Invoke(Coins);
    }
}