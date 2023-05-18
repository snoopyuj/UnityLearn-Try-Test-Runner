using System;

public class DamageCalculator
{
    public static int CalculateDamage(int _amount, float _mitigationPercent)
    {
        return Convert.ToInt32(_amount * _mitigationPercent);
    }
}
