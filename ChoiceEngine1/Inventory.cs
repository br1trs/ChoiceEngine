using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
namespace ChoiceEngine1;

public class Inventory
{
    private readonly List<int> _itemAmounts = new();
    private readonly List<Item?> _items = new();
    private readonly List<Item?> _justDeleted = new();
    private readonly List<int> _justDeletedAmounts = new();

    public void AddItem(Item? item, int quantity)
    {
        if (_items.Contains(item))
        {
            _itemAmounts[_items.IndexOf(item)] += quantity;
        }
        else
        {
            _items.Add(item);
            _itemAmounts.Add(quantity);
        }
    }

    public void RemoveItem(int quantity, string? itemName = null, Item? item = null)
    {
        if (itemName != null) item = _items.FirstOrDefault(i => i.Name == itemName);

        if (!_items.Contains(item)) return;
        _itemAmounts[_items.IndexOf(item)] -= quantity;
        _justDeleted.Add(item);
        _justDeletedAmounts.Add(quantity);
    }

    public int GetItemAmount(string? itemName = null, Item? item = null)
    {
        if (itemName != null) item = _items.FirstOrDefault(i => i.Name == itemName);
        return _items.Contains(item) ? _itemAmounts[_items.IndexOf(item)] : 0;
    }

    public Item? GetItem(string? itemName = null, Item? item = null)
    {
        if (itemName != null)
        {
            item = _items.FirstOrDefault(i => i.Name == itemName);
        }

        return _items.Contains(item) ? _items[_items.IndexOf(item)] : null;
    }

    public Item[] GetGuns()
    {
        return _items.Where(i => i?.GetType() == typeof(Gun)).ToArray();
    }

    public Item GetBandage()
    {
        return _items.FirstOrDefault(i => i?.GetType() == typeof(Bandage));
    }
    
    public Item GetEnergyDrink()
    {
        return _items.FirstOrDefault(i => i?.GetType() == typeof(StaminaDrink));
    }

    public void UndoRemove()
    {
        for (var i = 0; i < _justDeleted.Count; i++) AddItem(_justDeleted[i], _justDeletedAmounts[i]);
        _justDeleted.Clear();
        _justDeletedAmounts.Clear();
    }

    public void DeleteHistory()
    {
        _justDeleted.Clear();
        _justDeletedAmounts.Clear();
    }

    public void Clear()
    {
        _items.Clear();
        _itemAmounts.Clear();
    }

    public DataTable GetTable()
    {
        var dt = new DataTable();
        dt.Columns.Add("Item");
        dt.Columns.Add("Amount");
        for (var i = 0; i < _items.Count; i++) dt.Rows.Add(_items[i].Name, _itemAmounts[i]);
        return dt;
    }
}