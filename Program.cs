using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of stalls available: ");
        int n = int.Parse(Console.ReadLine());
        bool[] stalls = new bool[n];

        while (true)
        {
            Console.Write("Enter stall number to reserve (0 0 to exit): ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x <= 0 || y <= 0)
            {
                break;
            }

            x--;
            y--;

            if (!stalls[x] && !stalls[y])
            {
                stalls[x] = true;
                stalls[y] = true;

                Console.WriteLine("Stall status: " + GetStallStatus(stalls));
            }
            else if (stalls[x] || stalls[y])
            {
                Console.WriteLine("The stall is reserved.");
            }
            else
            {
                Console.WriteLine("The entrance can't be reserved.");
            }

            if (IsAllReserved(stalls))
            {
                Console.WriteLine("All stalls are reserved.");
                break;
            }
        }
    }

    static bool IsAllReserved(bool[] stalls)
    {
        foreach (bool stall in stalls)
        {
            if (!stall)
            {
                return false;
            }
        }

        return true;
    }

    static string GetStallStatus(bool[] stalls)
    {
        string status = "";

        foreach (bool stall in stalls)
        {
            status += (stall ? "X" : "_");
        }

        return status;
    }
}