using System;

namespace Poems.Poems
{
    /// <summary>
    /// Хокку
    /// </summary>
    internal class IssaKobayasi : IPoem
    {
        /// <inheritdoc />
        public string Text => $"Я прилег в тени, {Environment.NewLine}За меня толчет мой рис {Environment.NewLine}Горный ручеек.";
    }
}
