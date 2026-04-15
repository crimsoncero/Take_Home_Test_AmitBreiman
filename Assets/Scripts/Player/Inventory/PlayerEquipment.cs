using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEquipment : MonoBehaviour
{
    public Action<IEquipable> OnItemEquipped;
    public Action<IEquipable> OnItemUnequipped;
    
    public List<PlayerEquipSlot> EquipSlots = new List<PlayerEquipSlot>();

    private void Start()
    {
        InitSlots();
    }

    public void EquipItem(Equipment equipment)
    {
        PlayerEquipSlot slot = EquipSlots.Find(x => x.SlotType == equipment.EquipData.Slot);
        if (slot == null)
        {
            Debug.LogError($"EquipSlot {equipment.EquipData.Slot} not found");
            return;
        }
        
        if (slot.HasItem)
        {
            UnequipSlot(slot.SlotType);
        }
        
        slot.ChangeEquipment(equipment);
        OnItemEquipped?.Invoke(equipment);
    }

    public void UnequipSlot(EquipmentSlots slotType)
    {
        PlayerEquipSlot slot = EquipSlots.Find(x => x.SlotType == slotType);
        if (slot == null)
        {
            Debug.LogError($"EquipSlot {slotType} not found");
            return;
        }

        if (slot.HasItem)
        {
            OnItemUnequipped?.Invoke(slot.Equipment);
            slot.ChangeEquipment(null);
        }
    }
    private void InitSlots()
    {
        EquipSlots.Add(new PlayerEquipSlot(EquipmentSlots.Head));
        EquipSlots.Add(new PlayerEquipSlot(EquipmentSlots.Chest));
        EquipSlots.Add(new PlayerEquipSlot(EquipmentSlots.Legs));
        EquipSlots.Add(new PlayerEquipSlot(EquipmentSlots.Weapon));
    }
}
