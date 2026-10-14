//------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using Ucu.Poo.Cards;

namespace Ucu.Poo.Exercise
{
    /// <summary>
    /// Programa principal.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            Card card = new Card(Rank.Ace, Suit.Spades);
            SymbolFormat symbolFormat = new SymbolFormat(card);

            // Print(card, new ConsolePrinter());
            // Print(card, new FilePrinter());
            Print(symbolFormat, new ConsolePrinter());
            Print(symbolFormat, new FilePrinter());
        }

        /// <summary>
        /// Imprime una carta usando la impresora indicada.
        /// </summary>
        /// <param name="cardContent">El contenido de la carta a imprimir.</param>
        /// <param name="printer">La impresora a usar.</param>
        private static void Print(ICardContent cardContent, IPrinter printer)
        {
            printer.PrintCard(cardContent);
        }
    }
}