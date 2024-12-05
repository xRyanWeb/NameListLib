namespace NameListLib
{
    public class NamesLib
    {
        public static List<string> Names = new List<string>();
        public static Random r = new Random();


        public static void SetName(List<string> name)
        {
            Names = name;

        }



        public static string RandName(string name1, 
            string name2, string name3)
        {


            Names.Add(name1);
            Names.Add(name2);
            Names.Add(name3);

            return Names[r.Next(Names.Count)];

        }


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
