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

}


