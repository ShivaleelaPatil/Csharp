/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2NOV18
{

    public class Team
    {
        public string TeamName ;

        Player[] p = new Player[5];
        public void TeamDetails()
        {
            Console.WriteLine("Details of November 12 Cricket Match");
            Console.WriteLine("Enter  Name of team");//Team1 details
            
            
                TeamName = Console.ReadLine();
            
        }

    }



    public class Player
    {
        Team[] t1 = new Team[2];



        public string[] PlayerName = new string[5];
        public int[] Score = new int[5];
        public int Totalscore = 0;
        public string TeamScore;
        public string ManOfTeam;
        public int Index;
        public int MaxScore;


        public void PlayerDetails()
        {


            Console.WriteLine("Enter Players Name of team");
            for (int i = 0; i < 5; i++)
            {
                PlayerName[i] = Console.ReadLine();
            }
            Console.WriteLine("Enter the score of each Player in team");
            for (int i = 0; i < 5; i++)
            {
                Score[i] = Convert.ToInt32(Console.ReadLine());
                if(MaxScore<Score[i])
                {
                    MaxScore = Score[i];
                }
                Totalscore = Totalscore + Score[i];
                
            }
            Console.ReadLine();
            Console.WriteLine("Total score is:"+ Totalscore);
            for (int i = 0; i < 4; i++)
            {
                
                if (Score[i] > Score[i + 1])
                {
                    int MaxScore;
                    Score[i] = Convert.ToInt32(Console.ReadLine());
                    MaxScore = Score[i];
                    Console.ReadLine();
                }

            }
            Console.WriteLine("Maximum Score is:"+ MaxScore);
            Index = Array.IndexOf(Score, MaxScore);
        }
        public void PrintPlayer()
        {
            
                Console.WriteLine("Players are:"+ PlayerName);
                Console.WriteLine("Score of Players:"+ Score);
                Console.ReadLine();

            
            
            
            Console.WriteLine("Maximum scorer name of team"+ PlayerName[Index]);
            Console.ReadLine();
        }
    }

class Program
    {
        static void Main(string[] args)
        {

            Team[] t = new Team[2];
            t[0] = new Team();
            t[0].TeamDetails();
            t[1] = new Team();
            t[1].TeamDetails();
            Player[] p1 = new Player[5];
            for(int i=0;i<5;i++)
            {
                p1[i] = new Player();
                p1[i].PlayerDetails();
                p1[i].PrintPlayer();
            }
        }
    }
}*/





















