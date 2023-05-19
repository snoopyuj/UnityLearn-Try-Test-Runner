using NSubstitute;
using NUnit.Framework;

public class character_with_inventory
{
    [Test]
    public void with_90_armor_takes_10_percent_damage()
    {
        // Arrange
        var pants = new Item() 
        { 
            EquipSlot = EquipSlots.Legs, 
            Armor = 40,
        };

        var shield = new Item()
        {
            EquipSlot = EquipSlots.RightHand,
            Armor = 50,
        };

        var character = Substitute.For<ICharacter>();
        var inventory = new Inventory(character);

        inventory.EquipItem(pants);
        inventory.EquipItem(shield);
        character.Inventory.Returns(inventory);

        // Act
        var calculatedDamage = DamageCalculator.CalculateDamage(1000, character);

        // Assert
        Assert.AreEqual(100, calculatedDamage);
    }
}