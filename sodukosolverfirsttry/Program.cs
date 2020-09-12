using System;

namespace sodukosolverfirsttry
{
    class Program
    {
        public void printBoard(int[,] board)
        {
            for(int i = 0; i < 9; i++)
            {
                
                if (i % 3 == 0 && i != 0)
                {
                    Console.WriteLine("  - - - - - - - - - - - - -");
                }
                for (int j = 0; j < board.GetLength(0) ; j++)
                {
                    if (j == 0)
                    {
                        string thisOne0 = " | ";
                        thisOne0 = thisOne0.Replace("\n", "").Replace("\r", "");
                        Console.Write(thisOne0);
                    }
                    if (j % 3 == 0 && j != 0)
                    {
                        string thisOne = " | ";
                        thisOne = thisOne.Replace("\n", "").Replace("\r", "");
                        Console.Write(thisOne);
                    }
                    if (j == 8)
                    {
                       
                        string thisOne2 = board[i, j].ToString();
                        thisOne2 = thisOne2.Replace("\n", "").Replace("\r", "");
                        Console.Write(thisOne2);
                        Console.WriteLine(" | ");
                    }
                    else
                    {
                        string thisOne3 = board[i, j] + " ";
                        thisOne3 = thisOne3.Replace("\n", "").Replace("\r", "");
                        Console.Write(thisOne3);
                    }
                
                }
            }
        }

        public int[] findEmptySpot(int[,] board)
        {
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y< 9; y++)
                {
                    if (board[x, y] == 0)
                    {
                        return new int[] { x, y };
                    }
                }
            }
            return new int[] { 9, 9 };
            // if it returns 9,9 then we are done
        }
        static void Main(string[] args)
        {
            int[,] board = new int[,] { 
                {0,5,9,6,0,0,0,1,0},
                {0,8,0,1,0,9,0,0,5},
                {1,3,2,0,7,0,0,0,0},
                {0,9,1,7,0,0,0,0,2},
                {2,0,0,0,0,0,0,0,9},
                {8,0,0,0,0,2,5,7,0},
                {0,0,0,0,4,0,1,5,8},
                {5,0,0,8,0,3,0,9,0},
                {0,4,0,0,0,5,7,6,0} };
            Program p = new Program();
            p.printBoard(board);
            Console.WriteLine(p.findEmptySpot(board)[0] + " " + p.findEmptySpot(board)[1]);
            
        }
    }
}
