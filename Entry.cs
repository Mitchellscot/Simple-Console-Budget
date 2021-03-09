using System;
using System.Collections.Generic;

public class Entry
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public Double Amount { get; set; }
    public Catagory Catagory { get; set; }
    public string Description { get; set; }

    public void SetDate(string date)
    {
        try
        {
            this.Date = DateTime.Parse(date);
            Console.WriteLine($"the date you entered is: {this.Date.ToShortDateString()}");
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);

        }
    }
    public void SetAmount(string amount)
    {
        try
        {
            this.Amount = Double.Parse(amount);
            Console.WriteLine("The amount you entered was: {0:C2}", this.Amount.ToString());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void SetCatagory(string s)
    {
        try
        {
            int i = int.Parse(s);
            switch (i)
            {
                case 1: this.Catagory = Catagory.Mortgage; break;
                case 2: this.Catagory = Catagory.Groceries; break;
                case 3: this.Catagory = Catagory.Clothing; break;
                default: this.Catagory = Catagory.uncatagorized; break;
            }
        }
        catch (System.Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Oh well, it will be uncatagorized i guess.");
        }
    }
    public void SetDescription(string s)
    {
        if (s == "s")
        {
            return;
        }
        else
        {
            this.Description = s;
        }
    }

    public static void AddEntry(Entry entry)
    {
        Console.WriteLine("Please enter a date for the expense you are entering: ");
        entry.SetDate(Console.ReadLine());
        Console.WriteLine("Please enter an amount: ");
        entry.SetAmount(Console.ReadLine());
        DisplayCatagories();
        entry.SetCatagory(Console.ReadLine());
        Console.WriteLine("Please enter a description, or press s to skip");
        entry.SetDescription(Console.ReadLine());

    }

    public static void DisplayAll(List<Entry> entries)
    {
        Console.WriteLine($"Here are the entries");
        foreach (var entry in entries)
        {
            Console.WriteLine($"{entry.Date.ToShortDateString()} | {entry.Amount:C2} | {entry.Catagory} | {entry.Description}");
        }
    }
    public static void DisplayCatagories()
    {
        Console.WriteLine("-------------------------------------");
        Console.WriteLine($"Please enter the number of the catagory this entry belongs to");
        Console.WriteLine("Mortgage: 1");
        Console.WriteLine("Groceries: 2");
        Console.WriteLine("Clothing: 3");
        Console.WriteLine("Uncatagorized: 4");
    }
}