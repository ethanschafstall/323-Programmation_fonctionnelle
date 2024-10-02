namespace exo_silkroad
{
    class Program
    {
        internal static void Main(String[] args)
        {
            const int BOARD_WIDTH = 8;
            const int BOARD_HEIGHT = 8;
            Console.CursorVisible = false;
            int kingXPos = BOARD_WIDTH;
            int kingYPos = BOARD_HEIGHT;
            // TODO Put silk on 30 more squares
            var board = PopulateBoard(BOARD_WIDTH, BOARD_HEIGHT);

            bool[,] testedCells = new bool[BOARD_WIDTH, BOARD_HEIGHT];

            // TODO Create a data structure that allow us to remember which square has already been tested
            DrawBoard(board);
            Console.WriteLine(FindPath(kingXPos, kingYPos));

            // TODO Create a data structure that allow us to remember the successful steps

            // TODO Write the recursive function
            // Recursive function that tells if we can reach H8 from the given position
            // The algorithm is in fact simple to spell out (even in french ;)):
            //
            //      Je peux sortir depuis cette case si:
            //          1. Je suis sur H8
            //
            //              ou
            //
            //          2. Je peux sortir depuis une des cases où je peux aller (et où je ne suis pas encore allé)

            // TODO Call the function and show the results

            Console.ReadLine();
        }
        static void DrawKing( int xPos, int yPos)
        {
            Console.SetCursorPosition(xPos, yPos);
            Console.Write("K");
            Console.SetCursorPosition(0, 0);
        }
        static bool[,] PopulateBoard(int width, int height) 
        {
            bool[,] board = new bool[width, height];
            int totalCellsToFill = width * height;
            int counter = 0;
            Random rand = new Random();
            while (counter != totalCellsToFill/2)
            {
                int ran1 = rand.Next(0, width );
                int ran2 = rand.Next(0, height );
                bool firstCond = (ran1 == 0 && ran2 == height-1 );
                bool secondCond = (ran2 == 0 && ran1 == width-1 );

                if (!firstCond && !secondCond)
                {
                    board[ran1, ran2] = true;
                    counter++;
                }
            }
            return board;
        }
        static void DrawBoard(bool[,] board)
        {
            // Print the column headers
            Console.Write("  ");
            for (int i = 0; i < board.GetLength(0); i++)
            {
                Console.Write(i + 1); // Print column numbers starting from 1
            }
            Console.WriteLine();

            // Top border
            Console.WriteLine($" ┌{new String('─', board.GetLength(0))}┐");

            // Print the board
            for (int row = 0; row < board.GetLength(1); row++)
            {
                Console.Write((row + 1) + "│"); // Print row numbers starting from 1
                for (int col = 0; col < board.GetLength(0); col++)
                {
                    if (board[col, row])
                    {
                        Console.Write("█"); // If true, print block
                    }
                    else
                    {
                        Console.Write(" "); // If false, print space
                    }
                }
                Console.WriteLine("│");
            }

            // Bottom border
            Console.WriteLine($" └{new String('─', board.GetLength(0))}┘");
        }

        static bool FindPath(int x, int y)
        {
            if (x = )
        }

    }
}