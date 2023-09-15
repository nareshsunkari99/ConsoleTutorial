using System.Collections;


namespace ConsoleTutorial.CollectionsDemo
{
    public  class DemoCollections
    {
        public void ListDemo()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Add(10);
            list.Remove(0);
            list.Remove(1);
            list.Remove(2);

            foreach(var i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
