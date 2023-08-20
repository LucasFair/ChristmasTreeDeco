namespace XmasTreeWithItsDeco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char starChar = '*';
            char spcChar = ' ';
            byte starRow;
            byte treeLen = 8;
            byte starChng = 1;

            Console.ForegroundColor = ConsoleColor.Green;  // Makes green the default color
            for (byte treeLenCnt = 1; treeLenCnt <= treeLen; treeLenCnt++)  // Shifts the order by starting at 1 instead of 0
            {
                starChng++; // Indexes by row
                starRow = (byte)(treeLen - treeLenCnt);  // Subtracts the amount to get the desired spacing
                for (byte spcCnt = 0; spcCnt < starRow; spcCnt++)
                {
                    Console.Write(spcChar);
                }
                for (byte starAddCnt = 0; starAddCnt < treeLenCnt; starAddCnt++)
                {
                    if (starAddCnt < 1)  // Add one star if the add counter is less than 1, otherwise add two
                    {
                        Console.Write(starChar);
                    }
                    else
                    {
                        if (starChng % 2 == 1)  // Changes every other row to red, remains green
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            //Console.Write(starChar + starChng);
                            Console.Write(starChar);
                        }
                        else
                        {
                            //Console.Write(starChar + starChng);
                            Console.Write(starChar);
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(starChar);
                    }
                }
                Console.WriteLine(string.Empty);  // Line breaks for each row
            }
            Console.ResetColor();  // Resets the color to white at the end
        }
    }
}