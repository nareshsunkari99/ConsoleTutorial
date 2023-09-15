namespace ConsoleTutorial.ArraysConcept
{
    public class DemoArrays
    {
        public void DemoOnSingleDimensions()
        {
            string[] names = { "A", "B", "C" };
            int[] age = new int[3];
            age[0] = 34;
            age[1] = 44;
            age[2] = 99;
            //  age[3] = 55; // Index outside

            int[] city = new int[] { 1, 2, 3 };

            foreach (int i in age)
            {
                Console.Write(i);
            }

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i], age[i], city[i]);
            }
        }

        public void DemoOnMultiDimensions()
        {
            string[,] names = { { "A","B" }, {"C","D" } };
            int[,] age = new int[2, 2];
            age[0, 0] = 22;
            age[1, 0] = 23;

            foreach(var items in names)
            {
                Console.WriteLine(items);
            }

            for (int i = 0, j = 0; i <j ;i++,j++)
            {
                Console.WriteLine(age[i,j]);
            }
        }
    }
}
