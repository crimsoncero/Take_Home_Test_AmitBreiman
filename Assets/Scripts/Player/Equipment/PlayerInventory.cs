using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public Action<EquipmentSo> OnItemEquipped;
    public Action<EquipmentSo> OnItemUnequipped;
    
    [field:SerializeField] public List<ItemSO> Items { get; private set; } = new List<ItemSO>();
    
    
}
