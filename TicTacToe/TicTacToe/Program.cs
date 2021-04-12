using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] tictactoeboard = new char[,]
            {
                { '-', '-', '-' },
                { '-', '-', '-' },
                { '-', '-', '-' }
            };
            printBoard(tictactoeboard);
            //PlayTicTacToe(player1, player2);
            bool factor = true;
            while (true)
            {
                try
                {
                    string turn = " ";
                    Console.Write("Player1 please enter your placement (1-9):  ");
                    turn = "player1";
                    int player1postition = int.Parse(Console.ReadLine());
                    while (player1postition < 0 || player1postition > 9)
                    {
                        Console.WriteLine("Please enter a corrent position (1-9): ");
                    }
                    checkInput(tictactoeboard, turn, player1postition);
                    printBoard(tictactoeboard);

                    Console.Write("Player2 please enter your placement (1-9):  ");
                    turn = "player2";
                    int player2postition = int.Parse(Console.ReadLine());
                    while (player2postition < 0 || player2postition > 9)
                    {
                        Console.WriteLine("Please enter a corrent position (1-9): ");
                    }
                    checkInput(tictactoeboard, turn, player2postition);
                    printBoard(tictactoeboard);


                    
                }
                catch (Exception e)
                {
                    Console.WriteLine("You did not enter a valid input");
                }
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (tictactoeboard[i,j] == '-')
                        {
                            continue;
                        }
                        else if (tictactoeboard[i,j] != '-') 
                        {
                            factor = false;
                            break; 
                        }
                    }

                }
            }


        }

        public static char[,] checkInput(char[,] array, string player, int input)
        {
            char symbol = ' ';

            if (player == "player1")
            {
                symbol = 'X';
            }
            else if (player == "player2")
            {
                symbol = 'O';
            }
            switch (input)
            {
                case 1:
                    array[0,0] = symbol;
                    break;
                case 2:
                    array[0,1] = symbol;
                    break;
                case 3:
                    array[0,2] = symbol;
                    break;
                case 4:
                    array[1,0] = symbol;
                    break;
                case 5:
                    array[1,1] = symbol;
                    break;
                case 6:
                    array[1,2] = symbol;
                    break;
                case 7:
                    array[2,0] = symbol;
                    break;
                case 8:
                    array[2,1] = symbol;
                    break;
                case 9:
                    array[2,2] = symbol;
                    break;
                default:
                    break;
            }
            return array;
        }
        public static void printBoard(char[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j]);
                }
                Console.WriteLine();
            }

        }
        

    }

      
}

