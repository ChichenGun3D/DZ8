using System;
using System.Collections;

public class BankTransaction
{
    private readonly DateTime dateTime;
    private readonly double amount;

    public BankTransaction(double amount)
    {
        this.dateTime = DateTime.Now;
        this.amount = amount;
    }

    public DateTime DateTime
    {
        get { return dateTime; }
    }

    public double Amount
    {
        get { return amount; }
    }
}

public class BankAccount
{
    private string accountNumber;
    private double balance;
    private string accountType;
    private Queue transactions;
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
        transactions = new Queue();
    }

    public BankAccount(double balance)
    {
        GenerateAccountNumber();
        this.balance = balance;
        accountType = "Не указан";
        transactions = new Queue();
    }

    public BankAccount(string accountType)
    {
        GenerateAccountNumber();
        this.balance = 0;
        this.accountType = accountType;
        transactions = new Queue();
    }

    public BankAccount(double balance, string accountType)
    {
        GenerateAccountNumber();
        this.balance = balance;
        this.accountType = accountType;
        transactions = new Queue();
    }

    public void Deposit(double amount)
    {
        balance += amount;
        transactions.Enqueue(new BankTransaction(amount));
    }

    public void Withdraw(double amount)
    {
        balance -= amount;
        transactions.Enqueue(new BankTransaction(-amount));
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
        BankAccount acc = new BankAccount(1000, "Депозитный");
        acc.Deposit(500);
        acc.Withdraw(200);
        acc.PrintInfo();
    }
}