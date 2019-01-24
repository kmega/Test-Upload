﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Cards;

namespace Core.Usecases.CardComparison
{
    public class BlackRedColourOnlyComparisonStrategy : ICardComparisonStrategy
    {
        public bool AreTheSame(Card card1, Card card2)
        {
            // Spades, Clubs (S, C) -> black
            // Hearts, Diamonds (H, D) -> red
            
                if (((card1.Colour() == "H" || card1.Colour() == "D")
                    && (card2.Colour() == "H" || card2.Colour() == "D"))
                    || ((card1.Colour() == "S" || card1.Colour() == "C")
                    && (card2.Colour() == "S" || card2.Colour() == "C")))
                {
                    return true;
                }
                else
                {
                    return false;
                }
        }
    }
}
