void DrawGameBoard(string[] board)
{
    int cellIndex = 0;
    for (int i = 0; i < 3; i++)
    {
        for (int j = 1; j <= 11; j++)
        {
            if (j % 4 == 0)
            {
                Console.Write("|");
            }
            else if (j % 2 == 0)
            {
                if (board[cellIndex] == "X" || board[cellIndex] == "O")
                {
                    Console.Write(board[cellIndex]);
                }
                else
                {
                    Console.Write(" ");
                }
                cellIndex++;
            }
            else
            {
                Console.Write(" ");
            }
        }
        if (i < 2)
        {
            Console.WriteLine();
            Console.WriteLine("---+---+---");
        }
    }
    Console.WriteLine();
}

Console.WriteLine("Welcome to tic-tac-toe!");

int moveCount = 0;
string[] board = new string[9];
DrawGameBoard(board);

do
{
    if (moveCount != 9)
    {
        string currentPlayer;
        if (moveCount % 2 == 0)
        {
            currentPlayer = "X";
        }
        else
        {
            currentPlayer = "O";
        }
        Console.Write($"{currentPlayer}'s move > ");

        int userMove = int.Parse(Console.ReadLine()) - 1;
        Console.WriteLine();
        if (board[userMove] == "X" || board[userMove] == "O" || userMove < 0 || board.Length <= userMove)
        {
            Console.WriteLine("Illegal move! Try again.");
            continue;
        }
        board[userMove] = currentPlayer;
        moveCount++;
        DrawGameBoard(board);
    }
    else
    {
        moveCount++;
        Console.WriteLine("Game over!");
    }
} while (moveCount < 10);