using System;
/*A company has name, address, phone number, fax number, web site and manager.
 * The manager has first name, last name, age and a phone number. Write a program
 * that reads the information about a company and its manager and prints them on the console.
 * */
class ManagerInfo
{
    static void Main()
    {
        Console.WriteLine("Enter Company Name :");
        string companyName = Console.ReadLine();
        Console.WriteLine("Enter Company Address :");
        string companyAddress = Console.ReadLine();
        Console.WriteLine("Enter Company fax number :");
        string faxNumber = Console.ReadLine();
        Console.WriteLine("Enter Company fax number :");
        string phoneNumber = Console.ReadLine();
        Console.WriteLine("Enter Company website :");
        string web = Console.ReadLine();
        Console.WriteLine("Enter Company Manager first name :");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter Company Manager last name :");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter Company Manager phone number :");
        string mphoneNumber = Console.ReadLine();

        Console.WriteLine(
            "company:{0}\n" +
            "address: {1}\n" +
            "phone number:{2}\n" +
            "fax number: {3}\n" +
            "website: {4}\n" +

            "manager: {5} {6}\n" +
            "manager phone number: {7}\n", companyName, companyAddress, phoneNumber, faxNumber, web, firstName, lastName, mphoneNumber);
    }
}