// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T newData)
    {
        storedData.Add(newData);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        if (storedData.Count == 0)
        {
            Console.WriteLine("No data stored.");
            return;
        }

        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, yang disimpan pada waktu UTC: {inputDates[i]}");
        }
    }
}

public class MainProgram

{
    public static void Main(string[] args)
    {
        SimpleDataBase<int> database = new SimpleDataBase<int>();
        database.AddNewData(12);
        database.AddNewData(34);
        database.AddNewData(56);
        database.PrintAllData();
    }
}




