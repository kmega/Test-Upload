﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Decks;
using Core.Entities.GameStates;
using Core.Usecases.InfluenceState;

namespace Core.Usecases.GameConditions
{
    /// <summary>
    /// If currentTurn >= maxTurns: declare game has been lost.
    /// </summary>
    public class DidTurnsExpire : IGameCondition
    {
        public void CheckAndUpdate(GameState currentGameState)
        {
            var currentTurn = QueryGameState.CurrentTurn(currentGameState);
            var maxTurn = QueryGameState.MaximumTurns(currentGameState);

            if (currentTurn >= maxTurn)
            {
                ModifyGameState.DeclareGameToBeLost(currentGameState);
            }
      
        }
    }
}
