class Blackbox
{
    public static void Main(String[] args)
    {

        //Input
        //tree
        Console.WriteLine("Where is your tree?");
        string treeParsed = Console.ReadLine();
        int tree = int.Parse(treeParsed);

        //lefthouseEnding
        Console.WriteLine("Where is the left ending of the house?");
        string leftEndingParsed = Console.ReadLine();
        int leftEnding = int.Parse(leftEndingParsed);

        //righthouseEnding
        Console.WriteLine("Where is the right ending of the house?");
        string rightEndingParsed = Console.ReadLine();
        int rightEnding = int.Parse(rightEndingParsed);
        //amountOfEntities
        Console.WriteLine("How much entities do you want to type in?");
        string mP = Console.ReadLine();
        int m = int.Parse(mP);

        //entities
        Console.WriteLine("Please type in your entities");
        int[] entities = new int[m];
        int i = 0;
        while (entities.Length > i )
        {
            entities[i] = Int32.Parse(Console.ReadLine());
            i++;
        }

        int area = CountEntities(tree, leftEnding, rightEnding, entities);
        Console.WriteLine(area);
    }
    static int CountEntities(int tree, int leftHouseEnding, int rightHouseEnding, int[] entities)
    {
        int count = 0;
        for (int i = 0; i < entities.Length; i++)
        {
            if (tree + entities[i] >= leftHouseEnding && tree + entities[i] <= rightHouseEnding)
            { count++; }
        }
        return count;
    }

    //OldOne
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

                //applesCounted
                Console.WriteLine("How many apples do you want to fall down?");
                int m = Int32.Parse(Console.ReadLine());
                int[] applesArray = new int[m];

                //orangesCounted
                Console.WriteLine("How many oranges do you want to fall down?");
                int n = Int32.Parse(Console.ReadLine());
                int[] orangesArray = new int[n];


                //indexes
                int i = 0;
                int t = 0;


                Console.WriteLine("Please fill in the thrown apples");
                while (i < m)
                {
                    applesArray[i] = Int32.Parse(Console.ReadLine());
                    i++;
                }

                Console.WriteLine("Please fill in the thrown oranges");
                while (t < n)
                {
                    orangesArray[t] = Int32.Parse(Console.ReadLine());
                    t++;
                }

                //Parse
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

            static void Berechnung(int leftHouseEnding, int rightHouseEnding, int orangeTree, int appleTree, int[] applesArray, int[] orangesArray)
            {
                var applesFallInHouse = applesArray.Select(item => item + appleTree)
                    .Where(item => item >= leftHouseEnding && item <= rightHouseEnding)
                    .ToArray();
                var orangesFallInHouse = orangesArray.Select(item => item + orangeTree)
                    .Where(item => item >= leftHouseEnding && item <= rightHouseEnding)
                    .ToArray();
                System.Console.WriteLine("apples " + applesFallInHouse.Length);
                System.Console.WriteLine("oranges " + orangesFallInHouse.Length);


            }
        }
    }
    class RobinTrainingWithoutSelectAndWhere
    {
        public static int[] throww { get; private set; }

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

                //applesCounted
                Console.WriteLine("How many apples do you want to fall down?");
                int m = Int32.Parse(Console.ReadLine());
                int[] applesArray = new int[m];

                //orangesCounted
                Console.WriteLine("How many oranges do you want to fall down?");
                int n = Int32.Parse(Console.ReadLine());
                int[] orangesArray = new int[n];


                //indexes
                int i = 0;
                int t = 0;
                int indexApples = 0;
                int indexOranges = 0;
                int ia = 0;
                int io = 0;

                Console.WriteLine("Please fill in the thrown apples");
                while (i < m)
                {
                    applesArray[i] = Int32.Parse(Console.ReadLine());
                    i++;
                }

                Console.WriteLine("Please fill in the thrown oranges");
                while (t < n)
                {
                    orangesArray[t] = Int32.Parse(Console.ReadLine());
                    t++;
                }

                //Parse
                string leftHouseEndingParsed = args[0];
                string rightHouseEndingParsed = args[1];
                string orangeTreeParsed = args[2];
                string appleTreeParsed = args[3];
                int leftHouseEnding = Int32.Parse(leftHouseEndingParsed);
                int rightHouseEnding = Int32.Parse(rightHouseEndingParsed);
                int orangeTree = Int32.Parse(orangeTreeParsed);
                int appleTree = Int32.Parse(appleTreeParsed);


                Berechnung(leftHouseEnding, rightHouseEnding, orangeTree, appleTree, applesArray, orangesArray, m, n, indexApples, ia, io, indexOranges);
            }

            static void Berechnung(int leftHouseEnding, int rightHouseEnding, int orangeTree, int appleTree, int[] applesArray, int[] orangesArray, int m, int n, int indexApples, int ia, int io, int indexOranges)
            {
                //Berechnen der Äpfel
                while (ia < applesArray.Length)
                {
                    applesArray[ia] = applesArray[ia] + appleTree;
                    ia++;
                }
                //Berechnen der Orangen
                while (io < orangesArray.Length)
                {
                    orangesArray[io] = orangesArray[io] + orangeTree;
                    io++;
                }
                ia = 0;
                io = 0;


                //Filtern der Äpfel
                while (ia < applesArray.Length)
                {
                    if (applesArray[ia] >= leftHouseEnding && applesArray[ia] <= rightHouseEnding)
                    {
                        indexApples++;
                    }
                    ia++;
                }
                //Filtern der Orangen
                while (io < orangesArray.Length)
                {
                    if (orangesArray[io] >= leftHouseEnding && orangesArray[io] <= rightHouseEnding)
                    {
                        indexOranges++;
                    }
                    io++;
                }
                Console.WriteLine(indexApples);
                Console.WriteLine(indexOranges);
            }
        }
    }




}


