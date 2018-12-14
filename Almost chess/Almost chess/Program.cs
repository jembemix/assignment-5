using System;

public class Almostchess
{
    public static void Main()
    {
        Console.WriteLine("__________::Almost Chess::_____________\n");

        string[,] array2D = new string[8, 8]
        {
            { "X", "X", "X", "X", "X", "X", "x", "X" },
            { "X", "X", "X", "X", "X", "X", "x", "X" },
            { " ", " ", " ", " ", " ", " ", " ", " " },
            { " ", " ", " ", " ", " ", " ", " ", " " },
            { " ", " ", " ", " ", " ", " ", " ", " " },
            { " ", " ", " ", " ", " ", " ", " ", " " },
            { "X", "X", "X", "X", "X", "X", "x", "X" },
            { "X", "X", "X", "X", "X", "X", "x", "X" },
        };

        Boolean Invalid = false;
        while (true)
        {
            Invalid = takeInput(array2D);

            if (!Invalid)
            {
                Console.WriteLine("Invalid Input. Exiting program now!");
                break;
            }
        }
    }

    static Boolean takeInput(string[,] array2D)
    {
        int TargetX = 0;
        int TargetY = 0;
        int DestinationX = 0;
        int DestinationY = 0;

        print(array2D);

        Console.WriteLine("Enter Target's X axis:");
        TargetX = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Target's Y axis:");
        TargetY = Convert.ToInt32(Console.ReadLine());

        if ((TargetX < 0 || TargetX > array2D.GetLength(0) - 1) ||
            (TargetY < 0 || TargetY > array2D.GetLength(1) - 1))
        {
            return false;
        }

        Console.WriteLine("Enter Destination's X axis:");
        DestinationX = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Destination's Y axis:");
        DestinationY = Convert.ToInt32(Console.ReadLine());

        string Target = getValueAtIndex(array2D, TargetX, TargetY);
        array2D = putValueAtIndex(array2D, Target, DestinationX, DestinationY);

        return true;
    }

    static void print(string[,] array2D)
    {
        //Console.Clear();

        Console.Write("    0   1   2   3   4   5   6   7  \n");
        for (int i = 0; i < array2D.GetLength(0); i++)
        {
            Console.Write("  +---+---+---+---+---+---+---+---+\n");
            Console.Write(i + " |");
            for (int j = 0; j < array2D.GetLength(1); j++)
            {
                Console.Write(" " + array2D[i, j] + " |");
            }
            Console.Write(Environment.NewLine);
        }
        Console.Write("  +---+---+---+---+---+---+---+---+\n");
        Console.Write(Environment.NewLine + Environment.NewLine);
    }

    static String getValueAtIndex(string[,] array2D, int TargetX, int TargetY)
    {
        String target = array2D[TargetX, TargetY];

        array2D[TargetX, TargetY] = " ";

        return target;
    }

    static string[,] putValueAtIndex(string[,] array2D, string Target, int DestinationX, int DestinationY)
    {
        array2D[DestinationX, DestinationY] = Target;

        return array2D;
    }
}
