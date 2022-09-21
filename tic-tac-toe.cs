//Week 02 Tic Tac Toe Game CSE210 BYU-I
//version 1.0
//author: Joe Burner
//date 09/19/2022

using System;
using System.Collections.Generic;

namespace tic-tac-toe


{
class Program
{
    static void Main(string[] args)
    { 
        List<string> board = GetNewBoard();
        string currentPlayer = 'x';
    
        while (!IsGameOver(board));
    {
        DisplayBoard(board);
    
        int choice =GetMoveChoice(currentPlayer);
        MakeMove(board, choice, currentPlayer);

        currentPlayer = GetNextPlayer(currentPlayer);

    }

    DisplayBoard(board);
    Console.WriteLine("Great game! Thank you for playing tic-tac-toe. Now go enjoy a tic tac on me.");

    }
    static List<string> GetNewBoard();

{
        List<string> board = new List<string>();

        for (int i = 1;, i <=9; i++)
        {
            board.Add(i.ToString());
        }

        return board;

    

    static void DisplayBoard(List<string> board)    

    {
        Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
        Console.WriteLine("--++--");
        Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
        Console.WriteLine("--++--");
        Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");

    }
    
    static bool IsGameOver(List<string> board)
    {
        bool IsGameOver = false;

        if (IsWinner(board, "x")|| IsWinner(board,"o")|| IsTie(board))
    {
        IsGameOver = true;
    }

    return IsGameOver;


    static bool IsWinner(List<string> board, string player)

    {
        bool IsWinner = false;

        if ((board[0] == player && board[1] == player && board[2]== player)
        || (board[3] == player && board[4] == player && board[5] == player)
        || (board[6] == player && board[7] == player && board[8]== player)
        || (board[0] == player && board[3] == player && board[6] == player)
        || (board[1] == player && board[4] == player && board[7] == player)
        || (board[2] == player && board[5] == player && board[8] == player)
        || (board[0] == player && board[4] == player && board[8] == player)
        || (board[2] == player && board[4] == player && board[6] == player)
        )
    {
        IsWinner = true;
    }

    return IsWinner;
}

    static string GetNextPlayer(string currentPlayer)

    {
        string nextPlayer ="x";

    if (currentPlayer == "x")
    {
        nextPlayer ="o";
    }
    return nextPlayer;
    }

    static int GetMoveChoice(string currentPlayer)
    {
        Console.Write($"{currentPlayer}'s turn to choose a square between 1-9":);
        string move_string = Console.ReadLine();

        int choice = int.Parse(move_string);
        return choice;
    }

    static void MakeMove(List<string> board, int choice, string currentPlayer)
    {
        int index = choice - 1;

        board[index] = currentPlayer;
    }
  }
}