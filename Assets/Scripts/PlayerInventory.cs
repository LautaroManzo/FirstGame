using System;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public bool HasKey { get; private set; }
    public int Coins { get; private set; }

    public event Action<int> CoinsChanged;

    public void PickUpKey()
    {
        HasKey = true;
        Debug.Log("Llave obtenida");
    }

    public void AddCoin()
    {
        Coins++;
        CoinsChanged?.Invoke(Coins);
    }
}