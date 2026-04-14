using UnityEngine;

/// <summary>
/// Interface for items that can be equipped to the character.
/// </summary>
public interface IEquipable
{
    /// <summary>
    /// Return the player stat modifiers when equipping the item.
    /// </summary>
    /// <returns></returns>
    public PlayerStats Equip();
    
    /// <summary>
    /// Return the player stat modifiers to undo the modification when the item was equipped.
    /// </summary>
    /// <returns></returns>
    public PlayerStats Unequip();
}
