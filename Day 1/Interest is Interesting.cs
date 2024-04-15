using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if (balance < 0)
            return 3.213f;
        else if (balance < 1000)
            return 0.5f;
        else if (balance < 5000)
            return 1.621f;
        else if (balance >= 5000)
            return 2.475f;
        else
            return 0.0f;
    }

    public static decimal Interest(decimal balance)
    {
        return Convert.ToDecimal(InterestRate(balance) / 100) * balance;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return Interest(balance) + balance;
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        decimal result = balance;
        int years = 0;
        while (result <= targetBalance)
        {
            result = AnnualBalanceUpdate(result);
            years++;
        }
        return years;
    }
}
