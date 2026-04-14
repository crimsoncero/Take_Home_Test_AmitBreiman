using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    
    
    [field:SerializeField] public List<Item> Items { get; private set; } = new List<Item>();


    public void AddItem(ItemData newItemData)
    {
        Item item = newItemData.CreateInstance();
    }
    
}
