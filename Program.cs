using System;
using System.Collections.Generic;
using static System.Console;

namespace BudgetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            WriteLine($"Would you like to enter an expense? y/n");
            var input = ReadLine();
            while (b == true)
            {
                List<Entry> entries = new List<Entry>();
                
                if (input == "y")
                {
                    while (true)
                    {
                    Entry entry = new Entry();
                    Entry.AddEntry(entry);
                    entries.Add(entry);
                    WriteLine("Would you like to add another? y/n");
                    var input2 = ReadLine();
                    if(input2 == "y")
                    {
                        continue;
                    }
                    else 
                    {
                        Entry.DisplayAll(entries);
                        b = false;
                        break;
                    }
                    }
                }
                else if (input =="n")
                {
                    WriteLine($"Alright, have a nice day.");
                    break;
                }
                else
                {
                    WriteLine("I'm sorry, i didn't understand. Can you try typing a y or a n?");
                }
            }
            WriteLine("End of program.");
        }
    }
}

