using UnityEngine;

[CreateAssetMenu(fileName = "Equipment", menuName = "Scriptable Objects/Items/Equipment")]
public class EquipmentSo : ItemSO, IEquipable
{
    [field: SerializeField] public PlayerStats StatModifiers { get; private set; }

    public PlayerStats Equip()
    {
        return StatModifiers;
    }

    public PlayerStats Unequip()
    {
        var undoStats = StatModifiers;
        undoStats.InverseStats();
        return undoStats;
    }
}
