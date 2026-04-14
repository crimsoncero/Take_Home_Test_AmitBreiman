using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

public class PlayerController : MonoBehaviour
{
    public Action OnStatsChanged;
    
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private PlayerInventory _inventory;
    [SerializeField] private PlayerEquipment _equipment;
    [FormerlySerializedAs("baseStats")] [SerializeField] private PlayerStatsSO statsSO;
    public PlayerStats ModifiedStats { get; private set; }
    public int CurrentHealth { get; private set; }

    private void Start()
    {
        ModifiedStats = statsSO.BaseStats;
        CurrentHealth = ModifiedStats.MaxHealth;
        
        _equipment.OnItemEquipped += equipment => ModifyStats(equipment.Equip());
        _equipment.OnItemUnequipped += equipment => ModifyStats(equipment.Unequip());
    }

    public void MovePlayer(InputAction.CallbackContext context)
    {
        Vector2 moveVector = context.ReadValue<Vector2>();
        
        int moveSpeed = Math.Max(0, ModifiedStats.MovementSpeed);
        _rb.linearVelocity = moveVector * moveSpeed;
    }
    
    private void ModifyStats(PlayerStats statModifiers)
    {
        ModifiedStats.ModifyStats(statModifiers);
        OnStatsChanged?.Invoke();
    }
    
}
