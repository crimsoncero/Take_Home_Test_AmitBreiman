using UnityEngine;

public class Item
{
    public ItemData Data { get; protected set; }
    
    public Item(ItemData data)
    {
        Data = data;
    }
    
}
