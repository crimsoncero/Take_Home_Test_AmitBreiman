using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

public class PlayerController : MonoBehaviour
{
    public Action OnStatsChanged;
    
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private PlayerInventory _inventory;
    [FormerlySerializedAs("baseStats")] [SerializeField] private PlayerStatsSO statsSO;
    public PlayerStats ModifiedStats { get; private set; }
    public int CurrentHealth { get; private set; }

    private void Start()
    {
        ModifiedStats = statsSO.BaseStats;
        CurrentHealth = ModifiedStats.MaxHealth;
        _inventory.OnItemEquipped += s => ModifyStats(s.Equip());
        _inventory.OnItemUnequipped += s => ModifyStats(s.Unequip());
    }

    public void MovePlayer(InputAction.CallbackContext context)
    {
        Vector2 moveVector = context.ReadValue<Vector2>();
        _rb.linearVelocity = moveVector * ModifiedStats.MovementSpeed;
    }
    
    private void ModifyStats(PlayerStats statModifiers)
    {
        ModifiedStats.ModifyStats(statModifiers);
        OnStatsChanged?.Invoke();
    }
    
}
