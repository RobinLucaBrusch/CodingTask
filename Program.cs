using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the position of the apple tree: ");
        int appleTree = int.Parse(Console.ReadLine());

        Console.Write("Enter the position of the orange tree: ");
        int orangeTree = int.Parse(Console.ReadLine());

        Console.Write("Enter the left end of the house: ");
        int leftHouseending = int.Parse(Console.ReadLine());

        Console.Write("Enter the right end of the house: ");
        int rightHouseending = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of apples thrown: ");
        int appleCount = int.Parse(Console.ReadLine());
        int[] apples = new int[appleCount];

        Console.WriteLine("Enter the apples:");

        for (int i = 0; i < appleCount; i++)
        {
            apples[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter the number of oranges thrown: ");
        int orangeCount = int.Parse(Console.ReadLine());
        int[] oranges = new int[orangeCount];

        Console.WriteLine("Enter the oranges:");

        for (int i = 0; i < orangeCount; i++)
        {
            oranges[i] = int.Parse(Console.ReadLine());
        }

        int applesOnHouse = CountFruitsOnHouse(appleTree, leftHouseending, rightHouseending, apples);
        int orangesOnHouse = CountFruitsOnHouse(orangeTree, leftHouseending, rightHouseending, oranges);

        Console.WriteLine("Apples on house: " + applesOnHouse);
        Console.WriteLine("Oranges on house: " + orangesOnHouse);
    }

    static int CountFruitsOnHouse(int treePosition, int leftHouseending, int rightHouseending, int[] fruits)
    {
        int count = 0;

        for (int i = 0; i < fruits.Length; i++)
        {
            int fruitPosition = treePosition + fruits[i];

            if (fruitPosition >= leftHouseending && fruitPosition <= rightHouseending)
            {
                count++;
            }
        }

        return count;
    }
}
