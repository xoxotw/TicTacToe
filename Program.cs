using System;

namespace TicTacToe
{
    class Program
    {
        
        static void Main(string[] args)
        {

            // Draw the board   

            Game ttt = new Game();
            ttt.Draw();

            ttt.Move();
            ttt.Draw();

            ttt.Move();
            ttt.Draw();


            // wait for player input Key 1 - 9

            Console.ReadLine();

                             
            // update Draw board
            //Console.WriteLine(board[1,1]);
                       

        }

        
    }
}
