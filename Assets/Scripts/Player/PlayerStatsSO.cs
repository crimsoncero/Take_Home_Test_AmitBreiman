using System;
using UnityEngine;
using UnityEngine.Serialization;

[Serializable]
public struct PlayerStats
{
    [FormerlySerializedAs("Health")] public int MaxHealth;
    public int Strength;
    public int Agility;
    public int Intellect;
    public int MovementSpeed;

    /// <summary>
    /// Modify the stats by adding the stats modifiers to them.
    /// </summary>
    /// <param name="statModifiers"></param>
    public void ModifyStats(PlayerStats statModifiers)
    {
        MaxHealth += statModifiers.MaxHealth;
        Strength += statModifiers.Strength;
        Agility += statModifiers.Agility;
        Intellect += statModifiers.Intellect;
        MovementSpeed += statModifiers.MovementSpeed;
    }

    /// <summary>
    /// Change the stats such they will have the inverse effect to the stats, undoing their change.
    /// </summary>
    public void InverseStats()
    {
        MaxHealth *= -1;
        Strength *= -1;
        Agility *= -1;
        Intellect *= -1;
        MovementSpeed *= -1;
    }
}


[CreateAssetMenu(fileName = "Player Base Stats", menuName = "Scriptable Objects/Player Base Stats")]
public class PlayerStatsSO : ScriptableObject
{
    [field: SerializeField] public PlayerStats BaseStats { get; private set; }
}
