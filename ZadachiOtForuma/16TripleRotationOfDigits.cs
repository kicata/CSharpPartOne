using System;

class TripleRotationOfDigits
{
    static void Main()
    {

        int number = int.Parse(Console.ReadLine());
        for (int i = 0; i < 3; i++)
        {   //ako e samo edna cifra da go otpe4eta napravo
            if (number > 9)
            {
                //mnogo vazen moment deli se na 10 da se vseme poslednoto 4islo 
                int lastNumber = number % 10;
                //deli se na 10 celoìsleno za da se mahne ostatyka
                number = number / 10;
                //ToString za da se slepiat dvete promenlivi
                string result = lastNumber.ToString() + number.ToString();
                //to ind 4rez parse za da se mahnat nulite ako ima takiva
                number = int.Parse(result);
            }
        }

        //int number = int.Parse(Console.ReadLine());
        //int lastNumber = number % 10;
        //Console.WriteLine(lastNumber);
        //number = number / 2;
        //Console.WriteLine(number);
        //string resylt=number.ToString();

        //Console.WriteLine(resylt.Length);


    }
}