namespace TextFileSearch
{
    /// <summary>
    /// Represents the result of a search for a given <see cref="SearchItem"/>.
    /// </summary>
    public class TextFileResult
    {
        /// <summary>
        /// Gets or sets the <see cref="TextFile"/>.
        /// </summary>
        public TextFile TextFile { get; set; }

        /// <summary>
        /// Gets or sets the number of references for a given <see cref="SearchItem"/> in the text file content.
        /// </summary>
        public int Count { get; set; }
    }
}
