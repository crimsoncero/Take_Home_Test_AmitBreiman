using UnityEngine;

public class Equipment : Item, IEquipable
{
    public bool IsEquipped { get; private set; }

    public EquipmentData EquipData => Data as EquipmentData;

    public Equipment(EquipmentData data) : base(data)
    {
        Data = data;
    }

    
    public PlayerStats Equip()
    {
        if(IsEquipped) return default(PlayerStats);
        
        IsEquipped = true;
        return EquipData.StatModifiers;
    }

    public PlayerStats Unequip()
    {
        if(!IsEquipped) return default(PlayerStats);
        
        IsEquipped = false;
        var undoModifiers = EquipData.StatModifiers;
        undoModifiers.InverseStats();
        return undoModifiers;
    }
}
