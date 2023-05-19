using NSubstitute;
using NUnit.Framework;

public class inventory
{
    [Test]
    public void only_allows_one_chest_to_be_equipped_at_a_time()
    {
        // Arrange
        var character = Substitute.For<ICharacter>();
        var inventory = new Inventory(character);
        var chest1 = new Item() { EquipSlot = EquipSlots.Chest };
        var chest2 = new Item() { EquipSlot = EquipSlots.Chest };

        // Act
        inventory.EquipItem(chest1);
        inventory.EquipItem(chest2);

        // Assert
        var equippedItem = inventory.GetItem(EquipSlots.Chest);
        Assert.AreEqual(equippedItem, chest2);
    }

    [Test]
    public void tells_character_when_an_item_is_equipped_successfully()
    {
        // Arrange
        var character = Substitute.For<ICharacter>();
        var inventory = new Inventory(character);
        var chest1 = new Item() { EquipSlot = EquipSlots.Chest };

        // Act
        inventory.EquipItem(chest1);

        // Assert
        character.Received().OnItemEquipped(chest1);
    }
}