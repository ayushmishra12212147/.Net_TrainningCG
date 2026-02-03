using NUnit.Framework;
using System;

[TestFixture]
public class UnitTest
{
    [Test]
    public void Test_Deposit_ValidAmount()
    {
        TestTrails account = new TestTrails(100m);
        account.Deposit(50m);

        Assert.AreEqual(150m, account.Balance);
    }

    [Test]
    public void Test_Deposit_NegativeAmount()
    {
        TestTrails account = new TestTrails(100m);

        Assert.Throws<Exception>(() => account.Deposit(-20m));
    }

    [Test]
    public void Test_Withdraw_ValidAmount()
    {
        TestTrails account = new TestTrails(200m);
        account.Withdraw(50m);

        Assert.AreEqual(150m, account.Balance);
    }

    [Test]
    public void Test_Withdraw_InsufficientFunds()
    {
        TestTrails account = new TestTrails(100m);

        Assert.Throws<Exception>(() => account.Withdraw(150m));
    }
}
