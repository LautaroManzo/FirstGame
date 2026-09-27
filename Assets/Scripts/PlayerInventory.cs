using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public bool HasKey { get; private set; }

    public void PickUpKey()
    {
        HasKey = true;
        Debug.Log("Llave obtenida");
    }
}