using NUnit.Framework;

public class inventory
{
    [Test]
    public void only_allows_one_chest_to_be_equipped_at_a_time()
    {
        // Arrange
        var inventory = new Inventory();
        var chest1 = new Item() { EquipSlot = EquipSlots.Chest };
        var chest2 = new Item() { EquipSlot = EquipSlots.Chest };

        // Act
        inventory.EquipItem(chest1);
        inventory.EquipItem(chest2);

        // Assert
        var equippedItem = inventory.GetItem(EquipSlots.Chest);
        Assert.AreEqual(equippedItem, chest2);
    }
}