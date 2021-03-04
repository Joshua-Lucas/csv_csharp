using System;

public class Transaction
{
    public int transactionNumber { get; }
    public DateTime date { get; set; }
    public string expenseCategory { get; set; }

    public string expense { get; set; }
    public decimal amount { get; set; }

    private static int transNumberSeed = 00000001;

    public Transaction(DateTime newDate, string newExpenseCategory, string newExpense, decimal newAmount)
    {
        this.transactionNumber = transNumberSeed;
        transNumberSeed++;
        this.date = newDate;
        this.expenseCategory = newExpenseCategory;
        this.expense = newExpense;
        this.amount = newAmount;
    }




}