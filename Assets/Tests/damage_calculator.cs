using NUnit.Framework;

public class damage_calculator
{
    [Test]
    public void sets_damage_to_half_with_50_percent_mitigation()
    {
        // Act
        var finalDamage = DamageCalculator.CalculateDamage(10, 0.5f);

        // Assert
        Assert.AreEqual(5, finalDamage);
    }

    [Test]
    public void calculates_2_damage_from_10_with_80_percent_mitigation()
    {
        // Act
        var finalDamage = DamageCalculator.CalculateDamage(10, 0.8f);

        // Assert
        Assert.AreEqual(2, finalDamage);
    }
}