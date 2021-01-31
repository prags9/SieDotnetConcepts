using System;

namespace Tic_Tac_Toe_Game
{
    public class Player
    {
        public string Name { get; set; }

        public Player(string name)
        {
            Name = name;
        }       
    }
    public class TicTacToe
    {
        Player _playerA, _playerB;
        string[] board = new string[9];

        public void PrintBoard()
        {
            //int n = 3;
            for (int i = 0; i < 9; i += 3)
            {
                for (int j = i; j < i + 3; j++)
                {
                    Console.Write($"|--{board[j]}--|");
                }
                Console.WriteLine();
            }

        }

        public TicTacToe()
        {
            for (int i = 0; i < 9; i += 3)
            {
                for (int j = i; j < i + 3; j++)
                {
                    board[j] = (j + 1).ToString();
                }
            }
        }

        public void Play()
        {
            Console.Write("Who plays first?");
            _playerA = new Player(Console.ReadLine());
            _playerB = new Player(_playerA.Name == "A" ? "B" : "A");
            PrintBoard();
            //lets assume who will play first, has to move with "X".            
            for (int i = 0; i < 9; i++)
            {
                if (i == 8)
                {
                    Console.WriteLine("Draw");
                    break;
                }
                if (i % 2 == 0)
                {
                    Console.WriteLine("Enter a slot number to enter X: ");
                    int ind = Int32.Parse(Console.ReadLine());
                    while(board[ind-1]=="X" || board[ind - 1] == "O")
                    {
                        Console.WriteLine("Invalid slot. Enter again");
                        ind = Int32.Parse(Console.ReadLine());
                    }
                    board[(ind) - 1] = "X";
                    PrintBoard();
                    string ans = CheckResult(board);
                    if (ans == "Continue")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(ans);
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Enter a slot number to enter O: ");
                    int ind = Int32.Parse(Console.ReadLine());
                    while (board[ind - 1] == "X" || board[ind - 1] == "O")
                    {
                        Console.WriteLine("Invalid slot. Enter again");
                        ind = Int32.Parse(Console.ReadLine());
                    }
                    board[(ind) - 1] = "O";
                    PrintBoard();
                    string ans = CheckResult(board);
                    if (ans == "Continue")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(ans);
                        break;
                    }
                }
                
            }
        }
        public string CheckResult(string[] board)
        {
            string line = null;
            for (int i = 0; i < 8; i++)
            {
                switch (i)
                {
                    case 0:
                        line = board[0] + board[3] + board[6];
                        break;
                    case 1:
                        line = board[1] + board[4] + board[7];
                        break;
                    case 2:
                        line = board[2] + board[5] + board[8];
                        break;
                    case 3:
                        line = board[0] + board[1] + board[2];
                        break;
                    case 4:
                        line = board[3] + board[4] + board[5];
                        break;
                    case 5:
                        line = board[6] + board[7] + board[8];
                        break;
                    case 6:
                        line = board[0] + board[4] + board[8];
                        break;
                    case 7:
                        line = board[2] + board[4] + board[6];
                        break;
                }
                
                if (line == "XXX")
                    return "Winner is X";
                else if (line == "OOO")
                    return "Winner is O";
                /*if (i == 7 && (line != "XXX" || line != "OOO"))
                    return "Draw";*/
            }
            return "Continue";
        }
        class Program
        {
            static void Main(string[] args)
            {
                TicTacToe t = new TicTacToe();
                Console.WriteLine("Welcome to Tic-Tac-Toe game!!");
                t.PrintBoard();
                t.Play();
            }
        }
    }
}
