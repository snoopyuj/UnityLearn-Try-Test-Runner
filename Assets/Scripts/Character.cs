using UnityEngine;

public class Character : MonoBehaviour, ICharacter
{
    public Inventory Inventory { get; set; }

    public int Health { get; set; }

    public int Level { get; }

    public void OnItemEquipped(Item _item)
    {
        Debug.Log($"You equipped the {_item} in {_item.EquipSlot}");
    }
}
