using System;
using UnityEngine;

public class InventoryWindow : MonoBehaviour
{
    private PlayerInventory _inventory;
    private PlayerEquipment _equipment;
    

    private void Start()
    {
        _inventory = GameManager.Instance.Player.Inventory;
        _equipment = GameManager.Instance.Player.Equipment;
    }
}
