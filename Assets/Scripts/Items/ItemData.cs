using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Scriptable Objects/Items/Item")]
public class ItemData : ScriptableObject
{
    [field: SerializeField] public string Name { get; private set; }
    [field: SerializeField] public Sprite Icon { get; private set; }
    [field: SerializeField, Multiline] public string Description { get; private set; }
    [field: SerializeField] public int Price { get; private set; }
    

    public Item CreateInstance()
    {
        return new Item(this);
    }
    
}
