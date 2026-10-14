//------------------------------------------------------------------------------
// <copyright file="SymbolFormat.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.Globalization;

namespace Ucu.Poo.Cards
{
    /// <summary>
    /// Representa un naipe de póker.
    /// </summary>
    public class SymbolFormat : ICardContent
    {
        public SymbolFormat(Card card)
        {
            this.card = card;
        }

        private Card card;

        public string GetTextToPrint()
        {
            string number;
            string symbol;
            switch (this.card.Suit)
            {
                case Suit.Hearts:
                    symbol = "♥";
                    break;
                case Suit.Diamonds:
                    symbol = "♦";
                    break;
                case Suit.Clubs:
                    symbol = "♣";
                    break;
                default:
                    symbol = "♠";
                    break;
            }

            int position = (int)this.card.Rank;
            if (position <= 8)
            {
                number = (position + 2).ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                number = this.card.Rank.ToString()[0].ToString();
            }
            return $"{number}{symbol}";
        }
    }
}