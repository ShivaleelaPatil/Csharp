using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13Nov18
{
    public class Details
    {
        public string Name;
        public int Id;
    }
   public class Team:Details
    {
        public int TotalScore = 0;
        public Player MaxScorer = new Player();

        public Player[] players = new Player[5];
        public void CaptureDetails()
        {
            Console.WriteLine("Enter Team Details: ");
            Console.WriteLine("enter Team Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Player Details: ");
            for (int i = 0; i < 5; i++)
            {
               
                players[i] = new Player();
                Console.WriteLine("Enter Id");
                players[i].Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter playername");
                players[i].Name = Console.ReadLine();
                Console.WriteLine("Enter Player Score");
                players[i].Score = Convert.ToInt32(Console.ReadLine());

                TotalScore = TotalScore + players[i].Score;

            }
            Console.WriteLine("Id".PadRight(20) + "Name".PadRight(20) + "Score");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(players[i].Id + "\t\t\t" + players[i].Name + "\t\t\t" + players[i].Score);
                
            }
            Console.ReadLine();
        }
        public void ManOfTeam()
        {
            
            for (int i=0;i<5;i++)
            {
                if (players[i].Score > MaxScorer.Score)
                {
                    MaxScorer.Score = players[i].Score;
                    MaxScorer.Name = players[i].Name;
                }
            }

        }

        public void Printmaximum()
        {
            Console.WriteLine("man of the team is" + MaxScorer.Name);
            Console.WriteLine("maximum score team is" + MaxScorer.Score);
            Console.ReadLine();
        }
           
        
            
    }
    public class Player:Details
    {

        public int Score = 0;
        public int MaxScorer=0;

        
    }
    public class Match
    {
        
        public Team[] t = new Team[2];
        
       
        public void ManofMatch()
        {
            t[0] = new Team();
            t[0].CaptureDetails();
            t[0].ManOfTeam();
            t[0].Printmaximum();
            t[1] = new Team();
            t[1].CaptureDetails();
            t[1].ManOfTeam();
            t[1].Printmaximum();
            for (int i=0;i<2;i++)
            {
                if (t[0].MaxScorer.Score > t[1].MaxScorer.Score)
                {
                    Console.WriteLine("Man of the match is:" + t[0].MaxScorer.Name);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("man of the match is" + t[1].MaxScorer.Name);
                    Console.ReadLine();
                }

            }

        }    
        
    
    }
    class Program
    {
        static void Main(string[] args)
        {
            Match M = new Match();
            M = new Match();
            M.ManofMatch();




        }
    }
}





















