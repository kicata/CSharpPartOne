using System;
/* A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
 * bank name, IBAN, BIC code and 3 credit card numbers associated with the account. Declare the variables needed 
 * to keep the information for a single bank account using the appropriate data types and descriptive names.*/


class BankAccountHolderVariables
{
    static void Main(string[] args)
    {
        string firstName = "Pencho";
        string midName = "Petkov";
        string lastName = "Bibonchev";
        string holderName = firstName + " " + midName + " "  +lastName;
        decimal balance = 0.00m;
        string bankName = "First Investment Bank";
        string iBAN = "12HG T178 92U";
        string bicCode = "HGT 121 7892U";
        string ccardNum1= "1234 5678 9123 4567";//na praktika tova idva ot klienta
        long ccardNum2 = 4321567891234567;
        long ccardNum3 = 8765567891234567;

        Console.WriteLine("A bank account has a holder name: " + holderName + "\n" + "Avaliable balance: " + balance +"lv."+ "\n"
            + bankName + "\n" + "IBAN: "+iBAN + "\n" + "BIC: "+  bicCode + "\n");
        Console.WriteLine("The Credit cards associated with this account are: " + "\n" + ccardNum1 + "\n" + ccardNum2 + "\n" + ccardNum3 + "\n");


    }
}

