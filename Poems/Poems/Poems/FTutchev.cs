namespace Poems.Poems
{
    /// <summary>
    /// Стих
    /// </summary>
    internal class FedTutchev : IPoem
    {
        /// <inheritdoc />
        public string Text =>
            @"Люблю грозу в начале мая,
Когда весенний, первый гром,
Как бы резвяся и играя,
Грохочет в небе голубом.";

        /// <inheritdoc />
        public string Author => "Ф. Тютчев";
    }
}
