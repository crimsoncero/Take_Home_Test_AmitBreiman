using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemShopView : MonoBehaviour
{
    [SerializeField] private TMP_Text  _name;
    [SerializeField] private Image _icon;
    [SerializeField] private TMP_Text _description;
    [SerializeField] private TMP_Text _price;
    [SerializeField] private TMP_Text _equipSlot;
    
    public ItemData Data { get; private set; }

    public void Initialize(ItemData data)
    {
        Data = data;
        _name.text = Data.name;
        _icon.sprite = Data.Icon;
        _description.text = Data.Description;
        _price.text = "Cost: " + Data.Price.ToString();

        if (Data is EquipmentData)
        {
            var equipData = data as EquipmentData;
            _equipSlot.text = equipData.Slot.ToString();
            _equipSlot.enabled = true;

        }
        else
        {
            _equipSlot.enabled = false;
        }
    }

    public void BuyItem()
    {
        
    }
    
    
    
}
