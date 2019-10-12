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
                                           
            // NEXT TO DO !!!!   IMPORTANT !!!!!!!!!!!!!!!!!!
            //update the board instead of drawing new boards.

        }

        // a player makes a move using any of the 1 - 9 keys, a Move gets assinged to the array.
        public void Move()
        {
            if (GetPlayer() == false)
            {
                board[0, 0] = "X";
            }
            else
            {
                board[0, 1] = "O";
            }
            moveCounter++; 
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
