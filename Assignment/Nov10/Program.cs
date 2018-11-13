/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov10
{
    class Program
    {
        static int MaxScore1, Index1;
        static int MaxScore2, Index2;
        static void Main(string[] args)
        {
            string[] Team1Players = new string[7];
            string[] Team2Players = new string[7];
            int[] Team1Score = new int[7];
            int[] Team2Score = new int[7];
            while (true)
            {

                Console.WriteLine("Details of November 10 Cricket Match");
                Console.WriteLine("Enter Players Name of team1");//Team1 details
                for (int i = 0; i < 7; i++)
                {
                    Team1Players[i] = Console.ReadLine();
                }
                Console.WriteLine("Enter the score of each Player in team1");
                for (int i = 0; i < 7; i++)
                {
                    Team1Score[i] = Convert.ToInt32(Console.ReadLine());
                }
                int MaxScore1 = Team1Score.Max();
                Console.WriteLine("Maximum Score of First Match is={0}", MaxScore1);
                int Index1 = Array.IndexOf(Team1Score, MaxScore1);
                Console.WriteLine("Man Of the Team1 is={0}", Team1Players[Index1]);//end of team1 details
                Console.WriteLine("Enter Players Name of team2");//team 2 details
                for (int i = 0; i < 7; i++)
                {
                    Team2Players[i] = Console.ReadLine();
                }
                Console.WriteLine("Enter the score of each Player in team2");
                for (int i = 0; i < 7; i++)
                {
                    Team2Score[i] = Convert.ToInt32(Console.ReadLine());
                }
                int MaxScore2 = Team2Score.Max();
                Console.WriteLine("Maximum Score of Second Match is={0}", MaxScore2);
                int Index2 = Array.IndexOf(Team2Score, MaxScore2);
                Console.WriteLine("Man Of the Team2 is ", Team2Players[Index2]);
                if (MaxScore1 > MaxScore2)
                {
                    Console.WriteLine("Man of the match is "+Team1Players[Index1]);
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Man of the match is "+Team2Players[Index2]);
                    Console.ReadLine();
                }
            }
        }
    }
}*/

















        
    

