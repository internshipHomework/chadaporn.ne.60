using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace XO
{
    class Program
    {
        static String[] board = new String[9];
        static String playsAgain = "Y";
        static int counter = 0;
 
        static void num()
        {
            for (int i = 0; i < 9; i++)
            {
                board[i] = i.ToString();
            }
        }
 
        static void playAgainMsg(String message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Do you want to play again?");
            if (Console.ReadLine().Equals("Y"))
                playsAgain.Equals("Y");
            else
                playsAgain.Equals("N");
        }
        static void Thank()
        {
            Console.WriteLine("Thank you for playing!");
            Console.ReadLine();
        }
 
        static void ask(String player)
        {
            Console.Clear();
            if (player == "X")
                Console.WriteLine("Player1: " + player);
            else
                Console.WriteLine("Player2: " + player);
            int selection;
 
            while (true)
            {
                Console.WriteLine("Please enter your selection.");
                drawBoard();
                selection = Convert.ToInt32(Console.ReadLine());
                if (selection < 0 || selection > 9 || (board[selection].Equals("X") || board[selection].Equals("O")))
                    Console.WriteLine("Invalid selection!");
                else
                    break;
            }
            board[selection] = player;
        }
 
        static void drawBoard()
        {
            for (int i = 0; i < 7; i+=3){
                Console.WriteLine(board[i] + " | " + board[i + 1] + " | " + board[i +2]);  
            } 
        }
 
        static Boolean win()
        {
            
            if (board[0].Equals(board[1]) && board[1].Equals(board[2]))
                return true;
            if (board[3].Equals(board[4]) && board[4].Equals(board[5]))
                return true;
            if (board[6].Equals(board[7]) && board[7].Equals(board[8]))
                return true;
            if (board[0].Equals(board[3]) && board[3].Equals(board[6]))
                return true;
            if (board[1].Equals(board[4]) && board[4].Equals(board[7]))
                return true;
            if (board[2].Equals(board[5]) && board[5].Equals(board[8]))
                return true;
            if (board[2].Equals(board[4]) && board[4].Equals(board[6]))
                return true;
            if (board[0].Equals(board[4]) && board[4].Equals(board[8]))
                return true;
            else
                return false;
        }
        static void intro()
        {
            Console.WriteLine("Welcome to Tic Tac Toe.");
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
            Console.Clear();
        }

        static void Main(string[] args)
        {
            intro();
            while (playsAgain.Equals("Y"))
            {
                num();
                while (win() == false && counter < 9)
                {
                    ask("X");
                    if (win() == true)
                        break;
                    ask("O");
                }
                if (win() == true)
                    playAgainMsg("Congratulations! You won!");
                else if (win() == false)
                    playAgainMsg("Sorry, but this was a tie game!");
            }
            Thank();
        }
 
    }
}
 