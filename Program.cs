namespace Prog_226_S23_Lecture_3_Overrides_Structs
{
    internal class Program
    {

        static TeamRoster london = new TeamRoster("Spitfire", "London");
        static TeamRoster sanFran = new TeamRoster("Dragons", "San Francisco");

        static void Main(string[] args)
        {
            Point origin = new Point(0, 0);
            //origin.X += 6;
            //origin.Y += 1;

            Point left = new Point(-5, 0);
            Point right = new Point(5,0);

            bool isOnRight = left > right;

            Console.WriteLine(isOnRight);

            AddValues(origin);
            Console.WriteLine(origin);

            // origin += new Point(6,1);

        }

        public static void AddValues(Point p)
        {
            p.X += 5;
            p.Y += 6;
        }

        public static void Example()
        {
            // Indexer
            // Operator Overides
            // structs - value
            // class - reference
            Preload();

            Console.WriteLine(london[0]);
            Console.WriteLine(sanFran[0]);


        }

        public static void Preload()
        {
            sanFran.AddPlayer(new Player("Tony", "10"));
            london.AddPlayer(new Player("Zack", "7"));
        }

    }
}