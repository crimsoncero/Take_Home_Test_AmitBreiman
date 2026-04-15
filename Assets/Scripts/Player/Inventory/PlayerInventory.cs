using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    
    
    [field:SerializeField] public List<Item> Items { get; private set; } = new List<Item>();
    [field:SerializeField] public int Gold { get; private set; } = 300;

    public void AddItem(ItemData newItemData)
    {
        Item item = newItemData.CreateInstance();
    }

    public void AddGold(int amount)
    {
        if(amount > 0)
            Gold += amount;
    }
    
    /// <summary>
    /// Removes the gold amount from the player's inventory.
    /// </summary>
    /// <param name="amount"></param>
    /// <returns>Returns whether there was enough gold to be removed, if there wasnt the action fails</returns>
    /// <exception cref="ArgumentException"></exception>
    public bool RemoveGold(int amount)
    {
        if (amount < 0)
            throw new System.ArgumentException("amount can't be negative");
        
        if (amount > Gold) return false;
        
        Gold -= amount;
        return true;
    }
    
}
