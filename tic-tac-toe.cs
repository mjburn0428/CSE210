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
}