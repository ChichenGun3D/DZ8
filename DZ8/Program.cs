using System;

public class BankAccount
{
    private string accountNumber;
    private double balance;
    private string accountType;
    private static int counter = 1000;

    private void GenerateAccountNumber()
    {
        counter++;
        accountNumber = "ACC-" + counter;
    }

    public BankAccount()
    {
        GenerateAccountNumber();
        balance = 0;
        accountType = "Не указан";
    }

    public BankAccount(double balance)
    {
        GenerateAccountNumber();
        this.balance = balance;
        accountType = "Не указан";
    }

    public BankAccount(string accountType)
    {
        GenerateAccountNumber();
        this.balance = 0;
        this.accountType = accountType;
    }

    public BankAccount(double balance, string accountType)
    {
        GenerateAccountNumber();
        this.balance = balance;
        this.accountType = accountType;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Номер счёта: {accountNumber}");
        Console.WriteLine($"Баланс: {balance}");
        Console.WriteLine($"Тип счёта: {accountType}");
        Console.WriteLine(new string('-', 30));
    }
}

class Program
{
    static void Main()
    {
        BankAccount acc1 = new BankAccount();
        BankAccount acc2 = new BankAccount(1500.50);
        BankAccount acc3 = new BankAccount("Депозитный");
        BankAccount acc4 = new BankAccount(2500.00, "Кредитный");

        acc1.PrintInfo();
        acc2.PrintInfo();
        acc3.PrintInfo();
        acc4.PrintInfo();
    }
}
