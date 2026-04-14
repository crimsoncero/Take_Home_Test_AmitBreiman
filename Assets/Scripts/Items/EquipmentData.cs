using UnityEngine;

public enum EquipmentSlots
{
    Head,
    Chest,
    Legs,
    Weapon,
}

[CreateAssetMenu(fileName = "Equipment", menuName = "Scriptable Objects/Items/Equipment")]
public class EquipmentData : ItemData
{
    [field: SerializeField] public PlayerStats StatModifiers { get; private set; }
    [field: SerializeField] public EquipmentSlots Slot { get; private set; }

    public new Item CreateInstance()
    {
        return new Equipment(this);
    }
}
