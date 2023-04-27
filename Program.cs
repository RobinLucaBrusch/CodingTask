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
            Console.WriteLine("Please fill in the thrown apples");

            while (applesArray.Length <= Int32.Parse(m))
            {
                Console.WriteLine("Please fill in the thrown apples");
            }

            string leftHouseEndingParsed = args[0];
            string rightHouseEndingParsed = args[1];
            string orangeTreeParsed = args[2];
            string appleTreeParsed = args[3];

            int leftHouseEnding = Int32.Parse(leftHouseEndingParsed);
            
            int rightHouseEnding = Int32.Parse(rightHouseEndingParsed);
            
            
            int orangeTree = Int32.Parse(orangeTreeParsed);
            int appleTree = Int32.Parse(appleTreeParsed);
            


            var oranges = new[] { 3, -2, -4 };
            var apples = new[] { 2, 3, -4 };
            Berechnung(leftHouseEnding, rightHouseEnding, orangeTree, appleTree, apples, oranges);
        }

        static void Berechnung(int leftHouseEnding, int rightHouseEnding, int orangeTree, int appleTree, int amountOfApples, int amountOfOranges, int[] apples, int[] oranges)
        {
            var applesFallInHouse = apples.Select(item => item + appleTree)
                .Where(item => item >= leftHouseEnding && item <= rightHouseEnding)
                .ToArray();
            var orangesFallInHouse = oranges.Select(item => item + orangeTree)
                .Where(item => item >= leftHouseEnding && item <= rightHouseEnding)
                .ToArray();
            System.Console.WriteLine(applesFallInHouse.Length);
            System.Console.WriteLine(orangesFallInHouse.Length);


        }
    }
}