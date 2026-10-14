//------------------------------------------------------------------------------
// <copyright file="ICardContent.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

namespace Ucu.Poo.Cards
{
    /// <summary>
    /// Representa el contenido a imprimir de un naipe de póker.
    /// </summary>
    public interface ICardContent
    {
        string GetTextToPrint();
    }
}