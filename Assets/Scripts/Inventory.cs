using System.Collections.Generic;
using System.Linq;

public class Inventory
{
    private Dictionary<EquipSlots, Item> equippedItems = new();
    private List<Item> unequippedItems = new();

    public void EquipItem(Item _item)
    {
        if (equippedItems.ContainsKey(_item.EquipSlot))
        {
            unequippedItems.Add(equippedItems[_item.EquipSlot]);
        }

        equippedItems[_item.EquipSlot] = _item;
    }

    public Item GetItem(EquipSlots _equipSlot)
    {
        equippedItems.TryGetValue(_equipSlot, out var item);

        return item;
    }

    public int GetTotalArmor()
    {
        return equippedItems.Values.Sum(x => x.Armor);
    }
}