namespace ConsoleTutorial.ControlStatements
{
    public class Demoloops
    {

        //12345  - INTEGER
        //54321 - EXPECTED OUT

        public static void fordemo()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void fordemo(string input)
        {

            //accptance criteria count character occurnce in a given word
            // aan  a=2 n=1
            //for (int i = 0; i <= input.Length; i++)
            //{
            //    var myvalue = input[i];
            //}
            //aan
            //a==a

            int count = 0;
            string temp = ""; ;
            foreach (var character in input) 
            {

                foreach (var chara in input)
                {

                    if (!temp.Contains(character) && character == chara)
                    {
                        count++;
                    }
                   

                }
                if (!temp.Contains(character))
                Console.WriteLine("{0} = {1}", character, count);
                temp += character;
                
                //input = input.Replace(character.ToString(), string.Empty);
                count = 0;
            }
        }

        public static void whiledemo()
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }

        }

        public static void dowhiledemo()
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i > 10);

        }

        public static void foreachdemo()
        {
            string[] names = { "a", "b", "c", "d" };

            //for(int index=0;index<name.Length;index++)
            //{
            //    Console.WriteLine(name[index]);
            //}

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }


        }
    }
}
