using System;

class NextDate
{
    static void Main(string[] args)
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        //mnogo e vazno definiraneto na promenlivata i vzimaneto na info
        DateTime currentDate = new DateTime(year, month, day);
        currentDate = currentDate.AddDays(1);

        Console.WriteLine(currentDate.Day + "." + currentDate.Month + "." + currentDate.Year);


    }
}

