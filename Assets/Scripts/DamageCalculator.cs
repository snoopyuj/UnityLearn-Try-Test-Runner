using System;

public class DamageCalculator
{
    public static int CalculateDamage(int _amount, float _mitigationPercent)
    {
        var multiplier = 1f - _mitigationPercent;
        return Convert.ToInt32(_amount * multiplier);
    }

    public static int CalculateDamage(int _amount, Character _character)
    {
        var totalArmor = _character.Inventory.GetTotalArmor();
        var multiplier = (100f - totalArmor) * 0.01f;

        return Convert.ToInt32(_amount * multiplier);
    }
}
