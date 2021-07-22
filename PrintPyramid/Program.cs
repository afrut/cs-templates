using System;

namespace PrintPyramid
{
    class Program
    {
        static void printPyramid(int numRows)
        {
            // calculate total number of characters to print per row
            int numChar = (numRows * 2) - 1;

            // start and end position inclusive of when to print *
            int startPos = numRows;
            int endPos = numRows;

            for(int cntRow = 1; cntRow <= numRows; cntRow++)
            {
                for(int cntChar = 1; cntChar <= numChar; cntChar++)
                {
                    if( startPos <= cntChar && cntChar <= endPos )
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.Write('\n');

                // update the start and end positions
                startPos -= 1;
                endPos += 1;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows:");
            int cnt = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            printPyramid(cnt);
            Console.ReadKey();
        }
    }
}
