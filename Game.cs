using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Game
    {
        // 2D array variable represents the game board
        public string[,] board =
            {
                {" ", " ", " " },
                {" ", " ", " " },
                {" ", " ", " " },
           };

        // a variable to keep track of the moves, Player 1 is ODD and Player 2 is EVEN
        // a Player can first win after the 5th move is completed, That's when the WinChecker runs.
        public int moveCounter = 1;


        // Draws the board
        public void Draw()
        {
            Console.Clear();

            Console.WriteLine(Environment.NewLine + "TicTacToe v1.0" + Environment.NewLine);
            Console.WriteLine("     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[0, 0], board[0, 1], board[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[1, 0], board[1, 1], board[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[2, 0], board[2, 1], board[2, 2]);
            Console.WriteLine("     |     |");
                   
                                           
            // TO DO !!!!   IMPORTANT !!!!!!!!!!!!!!!!!!
            
            // make a game loop , instead of hardcoded move() draw() methods
            // a winCheck method that launches after the 5th move.
            // Who is the player to make a move notification.

        }

        // a player makes a move using any of the 1 - 9 keys, a Move gets assinged to the array.
        public void Move()
        {
            var input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.NumPad7:
                    {
                        if(GetPlayer() == false)
                        {
                            board[0, 0] = "X";
                        }
                        else
                        {
                            board[0, 0] = "O";
                        }
                            moveCounter++;
                            break;
                    }
                case ConsoleKey.NumPad8:
                    {
                        if (GetPlayer() == false)
                        {
                            board[0, 1] = "X";
                        }
                        else
                        {
                            board[0, 1] = "O";
                        }
                        moveCounter++;
                        break;
                    }
                case ConsoleKey.NumPad9:
                    {
                        if (GetPlayer() == false)
                        {
                            board[0, 2] = "X";
                        }
                        else
                        {
                            board[0, 2] = "O";
                        }
                        moveCounter++;
                        break;
                    }
                case ConsoleKey.NumPad4:
                    {
                        if (GetPlayer() == false)
                        {
                            board[1, 0] = "X";
                        }
                        else
                        {
                            board[1, 0] = "O";
                        }
                        moveCounter++;
                        break;
                    }
                case ConsoleKey.NumPad5:
                    {
                        if (GetPlayer() == false)
                        {
                            board[1, 1] = "X";
                        }
                        else
                        {
                            board[1, 1] = "O";
                        }
                        moveCounter++;
                        break;
                    }
                case ConsoleKey.NumPad6:
                    {
                        if (GetPlayer() == false)
                        {
                            board[1, 2] = "X";
                        }
                        else
                        {
                            board[1, 2] = "O";
                        }
                        moveCounter++;
                        break;
                    }
                case ConsoleKey.NumPad1:
                    {
                        if (GetPlayer() == false)
                        {
                            board[2, 0] = "X";
                        }
                        else
                        {
                            board[2, 0] = "O";
                        }
                        moveCounter++;
                        break;
                    }
                case ConsoleKey.NumPad2:
                    {
                        if (GetPlayer() == false)
                        {
                            board[2, 1] = "X";
                        }
                        else
                        {
                            board[2, 1] = "O";
                        }
                        moveCounter++;
                        break;
                    }
                case ConsoleKey.NumPad3:
                    {
                        if (GetPlayer() == false)
                        {
                            board[2, 2] = "X";
                        }
                        else
                        {
                            board[2, 2] = "O";
                        }
                        moveCounter++;
                        break;
                    }

            }
        }

        // a method to Retreive Player status.  If this is TRUE, it is Player 2, to make a move.
        // Player 2's move is represented by a "O"
        public bool GetPlayer()
        {
            if(moveCounter % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
