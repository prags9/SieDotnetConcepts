using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class Player
    {
        public string Name;
        public int Play; 
        public Player(string name, int play)
        {
            Name = name;
            Play = play;
        }
        public Player(string name)
        {
            Name = name;
        }
    }
    public class Ininngs
    {
        public Player batsman;
        public Player bowler;        
        public List<int> Score;
        public int TotalScore ;

        public Ininngs(Player batsman, Player bowler)
        {
            this.batsman = batsman;
            this.bowler = bowler;            
            Score = new List<int>();
        }

        public void AddScore(int score)
        {
            this.TotalScore += score;
            this.Score.Add(score);
            
        }
    }

    public class GestureThrow
    {
        public Random rnd = new Random();
        public  int Throws()
        {
            //Random random = new Random();
            /* List<int> list = new List<int>
             {
                 0,1,2,3,4,6
             };
             List<int> randomList = list.OrderBy(x => rnd.Next()).ToList();
             return randomList[0];*/
            int[] arr = new int[] { 0, 1, 2, 3, 4, 6 };
            int index = rnd.Next(6);
            return arr[index];
        }
    }

    public class HandCricket 
    {
        private Player _playerA, _playerB;
        private Player _batsman, _bowler;
        private Ininngs _innings1, _innings2;

        public HandCricket(Player playerA, Player playerB, Ininngs innings1, Ininngs innings2)
        {
            _playerA = playerA;
            _playerB = playerB;
            _innings1 = innings1;
            _innings2 = innings2;
        }

        public HandCricket()
        {
        }

        public void WhoPlaysNow()
        {
            Console.Write("Who bats first?");
            string s = Console.ReadLine();
            _playerA = new Player(s);
            string nextP = (s=="A") ? "B" : "A";
            _playerB = new Player(nextP);
            Console.WriteLine("Round1: ");
            _innings1 = PlayInnings(_playerA, _playerB);
            Console.WriteLine("Round2: ");
            _innings2 = PlayInnings(_playerB, _playerA);
            Winner(_innings1, _innings2);
        }
        public void Winner(Ininngs inn1, Ininngs inn2)
        {
            if(inn1.TotalScore>inn2.TotalScore)
                Console.WriteLine($"Game winner is {_playerA.Name}");
            else
                Console.WriteLine($"Game winner is {_playerB.Name}");
        }
        public Ininngs PlayInnings(Player batsman,Player bowler)
        {
            Ininngs inn = new Ininngs(_batsman, _bowler);
            GestureThrow gt = new GestureThrow();
            _batsman = batsman;
            _bowler = bowler;
            for (int i =0;i<6; i++)
            {
                _batsman.Play = gt.Throws();
                _bowler.Play = gt.Throws();
                if(_batsman.Play== _bowler.Play)
                {
                    Console.Write($"{_batsman.Name} throws {_batsman.Play}, {_bowler.Name} throws {_bowler.Play}. {_batsman.Name} is out");
                    break;
                }
                else
                {
                    inn.AddScore(_batsman.Play);
                    Console.Write($"{_batsman.Name} throws {_batsman.Play}, {_bowler.Name} throws {_bowler.Play}. {_batsman.Name}'s score is {inn.TotalScore}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            return inn;
        }
    }
    public class Program
    {

        public static void Main(string[] args)
        {
            HandCricket hc = new HandCricket();
            hc.WhoPlaysNow();
        }
       
    }
}
    


