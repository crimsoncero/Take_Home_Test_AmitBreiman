using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Scriptable Objects/Items/Item")]
public class ItemSO : ScriptableObject
{
    [field: SerializeField] public string Name { get; private set; }
    [field: SerializeField, Multiline] public string Description { get; private set; }
    [field: SerializeField] public int Price { get; private set; }

}
