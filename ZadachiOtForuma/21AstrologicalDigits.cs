using System;
using System.Threading;
using System.Globalization;
class AstrologicalDigits
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string number = Console.ReadLine();
        //4etem string poradi ograni4enieto na zada4ata 300 cifri.Avseki string sam po sebe  si  e maasiv ot charowe
        int sum = 0;
        //infinite loop na koito spira4kata e uslovieto v if-a
        while (true)
        {
            for (int i = 0; i < number.Length ; i++)
            {
                if (number[i] == '.' || number[i] == '-')
                {
                    continue;     
                }
                else
                {
                    //int.Parse iska string a ne char kakto e v momenta zatova .tosring
                    sum = sum + int.Parse(number[i].ToString());
                }
            }
            if (sum < 10)
            {
                break;
            }
            number = sum.ToString();
            sum = 0;
        }
        Console.WriteLine(sum);

    }
}

