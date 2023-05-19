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

        var inventory = new Inventory();

        inventory.EquipItem(pants);
        inventory.EquipItem(shield);

        var character = new Character() { Inventory = inventory };

        // Act
        var calculatedDamage = DamageCalculator.CalculateDamage(1000, character);

        // Assert
        Assert.AreEqual(100, calculatedDamage);
    }
}