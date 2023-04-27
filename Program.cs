class RobinTraining
{
    static void Main(string[] args)
    {
        if (args == null)
        {
            Console.WriteLine("Bitte etwas eingeben"); // Check for null array
        }
        else
        {
            //Get Data
            args = new string[4];
            Console.WriteLine("Please type in the left ending of the house");
            args[0] = Console.ReadLine();
            Console.WriteLine("Please type in the right ending of the house");
            args[1] = Console.ReadLine();
            Console.WriteLine("Where is the orange tree?");
            args[2] = Console.ReadLine();
            Console.WriteLine("Where is the apple tree?");
            args[3] = Console.ReadLine();
            Console.WriteLine("You should have typed in four numbers until now, you typed in " + args.Length);
            //apples
            Console.WriteLine("How many apples do you want to fall down?");
            string m = Console.ReadLine();
            string[] applesArray = new string[Int32.Parse(m)];
            //oranges
            Console.WriteLine("How many oranges do you want to fall down?");
            string n = Console.ReadLine();
            string[] orangesArray = new string[Int32.Parse(n)];

            int i = 0;
            int t = 0;

            Console.WriteLine("Please fill in the thrown apples");
            while (applesArray.Length <= Int32.Parse(m))
            {
                applesArray[i] = Console.ReadLine();
                i++;
            }
            Console.WriteLine("Please fill in the thrown oranges");
            while (orangesArray.Length <= int.Parse(n))
            {
                orangesArray[t] = Console.ReadLine();
            }
            string leftHouseEndingParsed = args[0];
            string rightHouseEndingParsed = args[1];
            string orangeTreeParsed = args[2];
            string appleTreeParsed = args[3];

            int leftHouseEnding = Int32.Parse(leftHouseEndingParsed);
            
            int rightHouseEnding = Int32.Parse(rightHouseEndingParsed);
            
            
            int orangeTree = Int32.Parse(orangeTreeParsed);
            int appleTree = Int32.Parse(appleTreeParsed);
            


            Berechnung(leftHouseEnding, rightHouseEnding, orangeTree, appleTree, applesArray, orangesArray);
        }

        static void Berechnung(int leftHouseEnding, int rightHouseEnding, int orangeTree, int appleTree, int amountOfApples, int amountOfOranges, int[] applesArray, int[] orangesArray)
        {
            var applesFallInHouse = applesArray.Select(item => item + appleTree)
                .Where(item => item >= leftHouseEnding && item <= rightHouseEnding)
                .ToArray();
            var orangesFallInHouse = orangesArray.Select(item => item + orangeTree)
                .Where(item => item >= leftHouseEnding && item <= rightHouseEnding)
                .ToArray();
            System.Console.WriteLine(applesFallInHouse.Length);
            System.Console.WriteLine(orangesFallInHouse.Length);


        }
    }
}