namespace NameListLib
{
    public class NamesLib
    {
        // Creates A List of Names Initizes a List of Items or Elements
        public static List<string> Names = new List<string>();
        public static Random r = new Random();
        // Initaizes Random Class

        // Makes Someone Set a Name For Names

        public static void SetName(List<string> name)
        {
            Names = name;

        }


        // This Code Randomly Selects a Name ina List of Strings
        // And Adds a Name to List and Selects Name from the
        // Entered List

        public static string RandName(string name1, 
            string name2, string name3)
        {


            Names.Add(name1);
            Names.Add(name2);
            Names.Add(name3);

            return Names[r.Next(Names.Count)];

        }


        // This Code Randomly Selects a Name ina List of Strings
        // And Adds a Name to List and Selects Name from the
        // Entered List

        public static string RandName2(string name1,
            string name2, string name3)
        {


            Names.Add(name1);
            Names.Add(name2);
            Names.Add(name3);

            return Names[r.Next(Names.Count)];

        }

    }
}
