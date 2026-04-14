using System;
using System.Collections.Generic;
using UnityEngine;

public class ItemShop : MonoBehaviour
{
    [SerializeField] private List<ItemData> _items;
    [SerializeField] private ItemShopView _itemShopViewPrefab;
    [SerializeField] private RectTransform _itemViewsContainer;
    private List<ItemShopView> _itemShopViews =  new List<ItemShopView>();

    private void Start()
    {
        foreach (var item in _items)
        {
            var itemView = Instantiate(_itemShopViewPrefab, _itemViewsContainer);
            itemView.Initialize(item);
            _itemShopViews.Add(itemView);
        }
        
    }
}
