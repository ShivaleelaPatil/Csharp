using System;

namespace AbstractConcept
{
    abstract public class SportsTeamDetails
    {
       public int _ID;
        public  string _Name;
        public abstract void SportsDetails();
     
    }
    public class Team : SportsTeamDetails
    {
       public int TeamScore=0;
      public  int MaxScore=0;

       
        Player[] p = new Player[4];
        public Player Maxscorer = new Player();
        Player p1= new Player();

        public override void SportsDetails()
        {
            Console.WriteLine("Enter the Team Details");
            Console.WriteLine("Enter Team ID");
            _ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Team Name:");
            _Name = Console.ReadLine();
            for (int i = 0; i < 4; i++)
            {
                p[i] = new Player();
                p[i].PlayerDetails();

                if (MaxScore < p[i].Score)
                {
                    MaxScore = p[i].Score;
                    Maxscorer._Name = p[i]._Name;
                }
                TeamScore = TeamScore + p[i].Score;

            }
            Console.WriteLine("Team Score is:" + TeamScore);
            Console.WriteLine("Maximum Score is:" + MaxScore);
            Console.WriteLine("Maximum Scorer is:" + Maxscorer._Name);
            Console.ReadLine();

        }

    }
       

       
        
    
           
        
    


    public   class Player: SportsTeamDetails
    {
      public  int Score;
      SportsTeamDetails sport;
        public string Maxscorer;
        public override void SportsDetails()
        {
            Console.WriteLine(" ");
        }
        public  int  PlayerDetails()
        {
            Console.WriteLine("Enter Player Details");
            Console.WriteLine(" ");
                Console.WriteLine("Enter Player Name:");
                Console.WriteLine("Enter Player id:");
                Console.WriteLine("Enter Player Score:");
                _Name = Console.ReadLine();
                _ID = Convert.ToInt32(Console.ReadLine());
                Score = Convert.ToInt32(Console.ReadLine());
                return Score;
               
            
        }

    }
    public class Match
    {
        public string ManOfMatch;
       public string WinningTeam;
        Team[] t = new Team[2];

        public Match()
        {
            Console.WriteLine(" ");
            t[0] = new Team();
            t[1] = new Team();
            t[0].SportsDetails();
            t[1].SportsDetails();
            if (t[0].TeamScore > t[1].TeamScore)
            {

                Console.WriteLine("Winning Team is:" + t[0]._Name);
                Console.WriteLine("TeamScore is:" + t[0].TeamScore);
            }
            else
            {
                Console.WriteLine("Winning Team is:" + t[1]._Name);
                Console.WriteLine("TeamScore is:" + t[1].TeamScore);

            }
            if (t[0].MaxScore > t[1].MaxScore)
            {
                Console.WriteLine("Man of the match is:" + t[0].Maxscorer._Name + " " + t[0].MaxScore);
            }

        }




    }
    class Program
    {
        static void Main(string[] args)
        {

            Match m = new Match();
            m = new Match();

        }
    }
}





