﻿using System;
using System.Collections.Generic;

namespace BetterBattleships
{
    public class GameManager
    {
        public void ManageBoard(IPlayer player)
        {
            new BoardPlacer().SetShipsOnBoard(player.GetBoard(), player.Name);
        }

        public void ManageGame(IPlayer player1, IPlayer player2)
        {
            var winner = new BattleshipGameExecutor().ProcessGameAndReturnWinner(player1, player2);
            new ConsoleDisplayer().DisplayWinnerAndEndGame(winner);
        }
    }
}