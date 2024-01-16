using _24_Paskaita_Generics;

namespace _25_Paskaita_Generics_P2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TwoGenerics<int, string> myClass = new TwoGenerics<int, string>(42, "Hello");

            myClass.PrintValues();
            myClass.SetProperty1(99);
            myClass.SetProperty2("World");
            myClass.PrintValues();

            //2

            FourSideGeometricFigure rectangle = new FourSideGeometricFigure("Rectangle", 5, 10);
            Console.WriteLine(rectangle.ToString());

            Generator<FourSideGeometricFigure> figureGenerator = new Generator<FourSideGeometricFigure>();

            figureGenerator.Show(rectangle);

            //3

            Type<string, int> type = new Type<string, int>();

            string value1 = "Hello";
            int value2 = 5;

            type.GetType(value1);
            type.GetType(value2);


            //Type<string, int> type2 = new Type<string, int>("Dovydas", 24);


            //4

            SportsLeague<Team> footballLeague = new SportsLeague<Team>();

            Team team1 = new Team { Name = "Team A", Sport = "Football" };
            Team team2 = new Team { Name = "Team B", Sport = "Football" };
            Team team3 = new Team { Name = "Team A", Sport = "Basketball" };

            footballLeague.AddTeam(team1);
            footballLeague.AddTeam(team2);
            footballLeague.AddTeam(team3);

            footballLeague.PrintTeams();

        }
    }
}