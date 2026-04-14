using JetBrains.Annotations;
using UnityEngine;

public class PlayerEquipSlot
{
    public EquipmentSlots SlotType { get; private set; }
    public Equipment Equipment { get; private set; }
    public bool HasItem =>  Equipment != null;

    public PlayerEquipSlot(EquipmentSlots slotType)
    {
        SlotType = slotType;
        Equipment = null;
    }
        
    public void ChangeEquipment([CanBeNull] Equipment equipment)
    {
        Equipment = equipment;
    }
}
