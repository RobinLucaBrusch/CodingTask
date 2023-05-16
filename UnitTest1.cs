namespace FruitCounter.Tests
{
    public class CountFruitsOnHouseTests
    {
        [Fact]
        public void CountFruitsOnHouseTest()
        {
            int treePosition = 5;
            int leftHouseending = 3;
            int rightHouseending = 7;
            int[] fruits = new int[] { 1, 2, 3, 4 };
            int result = CountFruitsOnHouse(treePosition, leftHouseending, rightHouseending, fruits);
            Assert.Equal(3, result);
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
}