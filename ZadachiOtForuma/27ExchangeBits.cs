using System;
//* Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.


class ExchangeBits
{
    static void Main(string[] args)
    {
        Console.Write("Enter Num= ");
        uint num = uint.Parse(Console.ReadLine());
        Console.WriteLine("number as binary {0}",Convert.ToString(num,2).PadLeft(32,'0'));
        Console.Write("Enter first bit position sequence= ");
        int firstSequenceBitPosition = int.Parse(Console.ReadLine());
        Console.Write("Enter second bit position sequence= ");
        int secondSequenceBitPosition = int.Parse(Console.ReadLine());
        int p = firstSequenceBitPosition;
        int q = secondSequenceBitPosition;
        Console.Write("Enter K to calculate range");
        int k = int.Parse(Console.ReadLine());
        if (k > 32)
        {
            Console.WriteLine("Start again k must be less than 32");
        }
        else
        {
            int endMemberPSeq = p + k - 1;
            int endMemberQSeq = q + k - 1;
            int maskRange = endMemberPSeq - p;
            Console.WriteLine("the sequence range is {0}",maskRange);
            uint maskNum=1;

            //calculate mask for work without loop
            for (int i = 0; i < maskRange; i++)
            {
                maskNum = 2 * maskNum + 1;
            }
            Console.WriteLine("The mask is ->{0}", maskNum);

            //If you want to work with loop unblock and block above
            // maskNum = 1;
            //for (int i = 0; i <= maskRange; i++)
            //{

                //get the bits at positions of p sequence
                uint maskP = maskNum << p;
                uint bitAtPositionPSeq = num & maskP;
                bitAtPositionPSeq = bitAtPositionPSeq >> p;

                //get the bits at positions of q sequence
                uint maskQ = maskNum << q;
                uint bitAtPositionQSeq = num & maskQ;
                bitAtPositionQSeq = bitAtPositionQSeq >> q;

                //setting bits at position p sequense to 0
                maskP = ~(maskNum << p);
                num = num & maskP;

                //setting bits at position q sequense to 0

                maskQ = ~(maskNum << q);
                num = num & maskQ;

                //Shift p to position q and OR the number
                bitAtPositionPSeq = bitAtPositionPSeq << q;
                num = num | bitAtPositionPSeq;

                //Shift q to position p and OR the number
                bitAtPositionQSeq = bitAtPositionQSeq << p;
                num = num | bitAtPositionQSeq;
                //p++;
                //q++;
           // }
            Console.WriteLine("The result is -> {0}",num);
            Console.WriteLine("number as binary {0}", Convert.ToString(num, 2).PadLeft(32, '0'));
        }

    }
}

