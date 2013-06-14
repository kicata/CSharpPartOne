﻿using System;
/*
 * A marketing firm wants to keep record of its employees.
 * Each record would have the following characteristics – first name, 
 * family name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999).
 * Declare the variables needed to keep the information for a single employee 
 * using appropriate data types and descriptive names.
 */

class CompanyEmployDataRecord
{
    static void Main(string[] args)
    {
        string firstName ="Pencho";
        string familyName="Petkov";
        byte age= 25;
        char gender = 'm'; 
        int IDnumber= 1234567;
        int uniqueEmployeeNumber = 27560000;

        Console.WriteLine("Employee: " + firstName + " " + familyName + "\n" + "Age:" + age + "\n" + "Gender:" + gender + "\n" +
            "Unique employee number: " + uniqueEmployeeNumber + "\n" + "ID number: " + IDnumber);
    }

}

